using Exel_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exel_Project
{
    public partial class Scan : Form
    {
        public string table { get; set; }
        async Task reloadDGVAsync()
        {
            reloadScanDGV();
        }

        public Scan(string table)
        {
            this.table = table;
            InitializeComponent();
            autoSetShift();
            autoLoadTime();
            initLineData();
            reloadModelName();
            btnAddNew.Enabled = false;
            reloadScanDGV();
            
        }

        private void Scan_Load(object sender, EventArgs e)
        {
            
        }
        private void initLineData()
        {
            List<int> data = new List<int>();
            for (int i = 1; i < 41; i++)
            {
                data.Add(i);
            }
            txtLine.DataSource = data;
        }
        private void autoLoadTime()
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd/MM/yyy";
            dateTimePicker.Value = DateTime.Now.Date;
            //dateTimePicker.Enabled = false;
        }
        private void autoSetShift()
        {
            var time = int.Parse(DateTime.Now.ToString("HH"));
            if (time >= 8 && time < 20)
            {
                comboBoxShift.SelectedIndex = 0;
            }
            else
            {
                comboBoxShift.SelectedIndex = 1;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        void reloadModelName()
        {
            List<string> data = BomModelModelDAO.getInstance().getListModelName();
            txtModel.DataSource = data;
            //txtModel.Text = "";
        }

        private ScanModel getScanModel()
        {
            var line = txtLine.Text;
            var quantity = txtQuantity.Text;
            ScanModel model = new ScanModel { scan = txtInput.Text, shift = comboBoxShift.Text, date = DateTime.Now.ToString("dd/MM/yyyy HH:mm"), code = txtCode.Text,quantity = Convert.ToDecimal(quantity),line = Convert.ToInt32(line), model = txtModel.Text, table = table};
            return model;
        }

        private async void btnAddNew_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = false;
            dateTimePicker.Value = DateTime.Now;
            addNew();
            txtInput.Text = "";
            await reloadDGVAsync();
        }

        private void txtModel_KeyDown(object sender, KeyEventArgs e)
        {
            //e.Handled = true;
        }

        private void reloadScanDGV()
        {
            string query = DBHelper.getQuery4ScanDGV(pageNum.Value, pageSize.Value, dateTimePicker.Value.ToString("dd/MM/yyyy"), table);
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            using (SqlConnection con = DBHelper.getConnection())
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dt);

                BindingSource bs = new BindingSource();
                bs.DataSource = dt;

                dgvScan.DataSource = bs;
                dataAdapter.Update(dt);
            }
        }
        private void reloadCode()
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if(txtInput.TextLength < 17)
            {
                btnAddNew.Enabled = false;
                
            }
            else
            {
                try
                {
                    var num = txtInput.Text.Substring(txtInput.TextLength - 6);
                    txtCode.Text = txtInput.Text.Substring(0, 11);

                    txtQuantity.Text = Convert.ToDecimal(num).ToString();
                    btnAddNew.Enabled = true;
                }catch(Exception ex)
                {

                }
                
            }
        }

        private async void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                //MessageBox.Show("Pressed enter.");
                dateTimePicker.Value = DateTime.Now;
                btnAddNew.Enabled = false;
                addNew();
                txtInput.Text = "";
                await reloadDGVAsync();
            }
        }
        async Task  addNew()
        {
            String message = "successfully";
            try
            {
                var model =  getScanModel();
                ScanDAO.getInstance().add(model);
                txtInput.Focus();
                await reloadDGVAsync();
            }catch(Exception e)
            {
                message = e.Message;
            }
            MessageBox.Show(message);
        }

        private async void pageNum_ValueChanged(object sender, EventArgs e)
        {
            await reloadDGVAsync();
        }

        private async void pageSize_ValueChanged(object sender, EventArgs e)
        {
            await reloadDGVAsync();
        }

        private async void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            await reloadDGVAsync();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                decimal id = Convert.ToDecimal(dgvScan.CurrentRow.Cells[0].FormattedValue);
                ScanDAO.getInstance().delete(id, table);
                dateTimePicker.Value = DateTime.Now;
                await reloadDGVAsync();
            }
            catch
            {

            }

        }
    }
}
