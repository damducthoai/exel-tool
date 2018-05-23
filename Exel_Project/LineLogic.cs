using Exel_DAO;
using Exel_Project.services;
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
        async Task deleteCurrentPlanAsync()
        {
            deleteCurrentPlan();
            
        }
        void  deleteCurrentPlan()
        {
            string message = "delete plan successfully";

            try
            {
                PlanService.getInstance().deletePlan(getPlanModel());
                //await reloadPlanDGVAsync();
                reloadPlanDGV();
            }
            catch(Exception e)
            {
                message = e.Message;
            }
            MessageBox.Show(message);
        }
        async Task reloadPlanDGVAsync()
        {

            reloadPlanDGV();
        }
        void reloadPlanDGV()
        {
            PlanModel plan = getPlanModel();
            
            string query = DBHelper.getQuery4PlanDGV(planPageNum.Value, planPageSize.Value, plan.plan_line,plan.component_id, "");
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

                planDGV.DataSource = bs;
                dataAdapter.Update(dt);

                txtPlanId.DataBindings.Clear();
                txtPlanId.DataBindings.Add("Text", bs, "plan_id", true);
                txtPlanTime.DataBindings.Clear();
                txtPlanTime.DataBindings.Add("Text", bs, "time", true);
                txtPlanValue.DataBindings.Clear();
                txtPlanValue.DataBindings.Add("Text", bs, "data", true);
                txtModel.DataBindings.Clear();
                txtModel.DataBindings.Add("Text", bs, "model", true);
                txtLineNum.DataBindings.Clear();
                txtLineNum.DataBindings.Add("Text", bs, "line", true);
            }

        }
        decimal getDecimalFromTextBox(TextBox textBox)
        {
            decimal res = -1;
            try
            {
                res = Convert.ToDecimal(textBox.Text);
            }
            catch (Exception e)
            {

            }
            return res;
        }
        PlanModel getPlanModel()
        {
            decimal plan_id = getDecimalFromTextBox(txtPlanId);
            
            decimal component_id = getDecimalFromTextBox(txtConponentId);
            string model_name = txtModel.Text;
            decimal plan_data = getDecimalFromTextBox(txtPlanValue);
            decimal plan_line = Convert.ToDecimal(txtLineNum.SelectedValue);
            string plan_time = getCurrentDate();
            PlanModel plan = new PlanModel { plan_id = plan_id ,component_id = component_id, model_name = model_name, plan_data = plan_data, plan_line = plan_line, plan_time = plan_time };
            return plan;
        }
        string getCurrentDate()
        {
            DateTime curTime = DateTime.Now;
            return curTime.ToString("dd/MM/yyy");
        }
        void addLineNumbers()
        {
            List<int> data = new List<int>();
            for (int i = 1; i < 41; i++)
            {
                //txtLineNum.Items.Add(i);
                data.Add(i);
            }
            txtLineNum.DataSource = data;
        }
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
