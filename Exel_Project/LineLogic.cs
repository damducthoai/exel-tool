using Exel_DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exel_Project
{
    partial class Line
    {
        async Task reloadModelNameAsync()
        {
            reloadModelName();
        }
        void reloadModelName()
        {
            List<string> data = BomModelModelDAO.getInstance().getListModelName();
            txtModel.DataSource = data;
            txtModel.Text = "";
        }
        async Task reloadComponentDGVAsync()
        {
            reloadComponentDGV();
        }
        void clearComponentBinding()
        {
            txtConponentId.DataBindings.Clear();
            txtConponentName.DataBindings.Clear();
        }
        void reloadComponentDGV()
        {
            string query = DBHelper.getQuery4LineComponentDGV(pageNum.Value, pageSize.Value, txtSearchString.Text);
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
                
                dgvComponent.DataSource = bs;
                dataAdapter.Update(dt);

                clearComponentBinding();
                txtConponentId.DataBindings.Add("Text", bs, "id", true);
                txtConponentName.DataBindings.Add("Text", bs, "name", true);
                //txtComponentName.DataBindings.Add("Text", bs, "name", true);
                //txtObjectDescription.DataBindings.Add("Text", bs, "description", true);
            }
        }
    }
}
