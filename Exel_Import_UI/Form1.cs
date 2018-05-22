using Exel_DAO;
using NPOI.XSSF.UserModel;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exel_Import_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task process()
        {
            BomModelModelDAO.getInstance().clearData();
            BOMDao.getInstance().clearData();
            string filePath = txtPath.Text;
            XSSFWorkbook workbook;
            using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                workbook = new XSSFWorkbook(file);

            }
            int errCount = 0;
            var sheet = workbook.GetSheet("BOM");
            var mainRow = sheet.GetRow(1);
            int rowCount = 0;
            for (int row = 2; row <= sheet.LastRowNum; row++)
            {

                if (sheet.GetRow(row) != null) //null is when the row only contains empty cells 
                {
                    rowCount += 1;
                    var curRow = sheet.GetRow(row);
                    string componentName = curRow.GetCell(2).StringCellValue;
                    string componentDescription = curRow.GetCell(3).StringCellValue;
                    decimal id = -1;
                    if (!BOMDao.getInstance().isExist(componentName))
                    {
                        BOMDao.getInstance().add(new BOM_Model { component_name = componentName, object_description = componentDescription });

                    }
                    id = BOMDao.getInstance().getComponentIdByName(componentName);

                    for (int i = 4; i <= curRow.LastCellNum; i++)
                    {
                        try
                        {
                            var x = curRow.GetCell(i).NumericCellValue;
                            string model = mainRow.GetCell(i).StringCellValue;
                            decimal num = Convert.ToDecimal(x);
                            if (num < 1) continue;
                            BomModelModelDAO.getInstance().add(new BOM_Model_Model { component_id = id, model_name = model, model_value = num });
                            Console.WriteLine(String.Format("{0} || {1}", x, model));
                        }
                        catch (Exception ex)
                        {
                            errCount += 1;
                            Console.WriteLine(String.Format("loi tai row {0} col {1}", row, i));
                            Console.WriteLine(ex.Message);
                        }
                    }
                    Console.WriteLine(string.Format("Row {0} = {1} : {2}", row, sheet.GetRow(row).GetCell(2).StringCellValue, sheet.GetRow(row).GetCell(3).StringCellValue));
                }
            }
            MessageBox.Show($"Done {rowCount} row");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog theDialog = new OpenFileDialog();
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = theDialog.FileName.ToString();
                txtPath.Text = filePath;
            }

        }

        private async void btnProcess_Click(object sender, EventArgs e)
        {
            await process();
        }
    }
}
