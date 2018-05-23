using Exel_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exel_Project.services;
using System.Data.SqlClient;
namespace Exel_Project
{
    public partial class BOM : Form
    {
        public BOM()
        {
            InitializeComponent();
            dgvBom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvBomModel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            reloadBom();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await reloadBomAsync();

        }
        BOM_Model getBomModel()
        {
            BOM_Model model = new BOM_Model {
                component_id = getDecimalFromTextBox(txtComponentId),
                component_name = txtComponentName.Text,
                object_description = txtObjectDescription.Text
            };
            return model;
        }
        BOM_Model_Model getBomDetail()
        {
            BOM_Model_Model model = new BOM_Model_Model {
                component_id = getDecimalFromTextBox(txtComponentId),
                model_name = txtComponentModelName.Text,
                model_value = getDecimalFromTextBox(txtComponentModelQuantity)
            };
            return model;
        }
        decimal getDecimalFromTextBox(TextBox textBox)
        {
            decimal res = -1;
            try
            {
                res = Convert.ToDecimal(textBox.Text); 
            } catch(Exception e)
            {

            }
            return res;
        }

        private async void btnSaveBomModel_Click(object sender, EventArgs e)
        {
            await saveAndReloadBom();
        }
        private async Task  saveAndReloadBom()
        {
            string message = MessageHelper.saveComponentSuccess;
            BOM_Model model = getBomModel();
            try
            {
                BomService.getInstance().save(model);
                reloadBom();
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            MessageBox.Show(message);
        }
        private async Task reloadBomAsync()
        {
            reloadBom();
        }
        private void reloadBom()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            using (SqlConnection con = DBHelper.getConnection())
            {
                con.Open();
                SqlCommand command = new SqlCommand(DBHelper.getStringSelecteForBomDGV(txtBomPageNum.Value,txtBomPageSize.Value, txtSearch.Text), con);
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dt);

                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dgvBom.DataSource = bs;
                dataAdapter.Update(dt);

                clearBomTxtBinding();
                txtComponentId.DataBindings.Add("Text", bs, "id", true);
                txtComponentName.DataBindings.Add("Text", bs, "name", true);
                txtObjectDescription.DataBindings.Add("Text", bs, "description", true);
            }
        }
        private void clearBomTxtBinding()
        {
            txtComponentId.DataBindings.Clear();
            txtComponentName.DataBindings.Clear();
            txtObjectDescription.DataBindings.Clear();
            
        }
        private void deleteBomById(decimal id)
        {
            if (id < 1) throw new Exception(MessageHelper.component_nothing_deleted);
            BomService.getInstance().deleteBomById(id);

        }
        private async Task  deleteAndReload()
        {
            string message = MessageHelper.component_deleted;
            try
            {
                deleteBomById(getDecimalFromTextBox(txtComponentId));
                reloadBom();
                
            }catch(Exception e)
            {
                message = e.Message;
            }
            MessageBox.Show(message);
        }

        private async void btnRefreshBom_Click(object sender, EventArgs e)
        {
            await reloadBomAsync();
        }

        private async void btnDeleteBom_Click(object sender, EventArgs e)
        {
            await deleteAndReload();
        }

        private async void txtComponentId_TextChanged(object sender, EventArgs e)
        {
            await reloadBomModel();
        }
        async Task reloadBomModel()
        {

            try
            {
                ((DataTable)((BindingSource)dgvBomModel.DataSource).DataSource).Clear();
            }
            catch (Exception e)
            {

            }
            dgvBomModel.Refresh();
            decimal bomId = getDecimalFromTextBox(txtComponentId);
            
            if (bomId > 0)
            {
                reloadComponentModel(bomId);
            }
        }
        void reloadComponentModel(decimal componentid)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            using (SqlConnection con = DBHelper.getConnection())
            {
                con.Open();
                SqlCommand command = new SqlCommand(DBHelper.getStringSelecteForBomModelDGV(txtBomModelPageNum.Value, txtBomModelPageSize.Value, componentid), con);
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dt);

                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dgvBomModel.DataSource = bs;
                dataAdapter.Update(dt);

                txtComponentModelName.DataBindings.Clear();
                txtComponentModelName.DataBindings.Add("Text", bs, "model", true);
                txtComponentModelQuantity.DataBindings.Clear();
                txtComponentModelQuantity.DataBindings.Add("Text", bs, "point", true);


            }
        }

        private async void btnSaveBomModelDetail_Click(object sender, EventArgs e)
        {
            await saveBomModel();
        }
        async Task saveBomModel()
        {
            string message = "model save successfully";
            try
            {
                BomModelService.getInstance().saveBomModel(getBomDetail());
                await reloadBomModel();
            }catch(Exception e)
            {
                message = e.Message;
            }
            MessageBox.Show(message);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void btnRefreshBomModel_Click(object sender, EventArgs e)
        {
            await reloadBomModel();
        }

        private async void txtBomModelPageNum_ValueChanged(object sender, EventArgs e)
        {
            await reloadBomModel();
        }

        private async void txtBomModelPageSize_ValueChanged(object sender, EventArgs e)
        {
            await reloadBomModel();
        }

        private async void txtBomPageNum_ValueChanged(object sender, EventArgs e)
        {
            await reloadBomAsync();
        }

        private async void txtBomPageSize_ValueChanged(object sender, EventArgs e)
        {
            await reloadBomAsync();
        }

        private async void btnDeleteBomModelDetail_Click(object sender, EventArgs e)
        {
            await deleteBomModelAsync(getBomDetail());
        }
        async Task deleteBomModelAsync(BOM_Model_Model model)
        {
            string message = "model delete successfully";
            try
            {
                //BomModelModelDAO.getInstance().delete(model);
                BomModelService.getInstance().delete(model);
                await reloadBomModel();
            }catch(Exception e)
            {
                message = e.Message;
            }
            MessageBox.Show(message);
        }

        private async void btnUpdateBom_Click(object sender, EventArgs e)
        {
            BOM_Model model = getBomModel();
            await updateBom(model);
        }
        async Task updateBom(BOM_Model model)
        {
            string message = "Update bom successfully";
            try
            {
                BomService.getInstance().updateBom(model);
                await reloadBomAsync();
            }catch(Exception e)
            {
                message = e.Message;
            }
            MessageBox.Show(message);
        }

        private async void btnUpdateModel_Click(object sender, EventArgs e)
        {
            BOM_Model_Model model = getBomDetail();
            await updateBomModel(model);
        }
        async Task updateBomModel(BOM_Model_Model model)
        {
            String message = "Update bom model successfully";
            try
            {
                BomModelService.getInstance().updateBomModel(model);
                await reloadBomModel();
            }catch(Exception e)
            {
                message = e.Message;
            }
            MessageBox.Show(message);
        }
    }
}
