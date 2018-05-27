using Exel_Project.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exel_Project
{
    public partial class Line : Form
    {
        public Line()
        {
            InitializeComponent();
            dgvComponent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            addLineNumbers();
            //reloadModelName();

            //dateTimePicker.Format = DateTimePickerFormat.Custom;
            //dateTimePicker.CustomFormat = "dd/MM/yyyy";
            txtPlanTime.Text = getCurrentDate();
            reloadComponentDGV();
            //reloadPlanDGVAsync();
        }

        private async void btnRefreshComponent_Click(object sender, EventArgs e)
        {
            await reloadComponentDGVAsync();
            //await reloadCountData();
        }

        private async void btnSearchComponent_Click(object sender, EventArgs e)
        {
            await reloadComponentDGVAsync();
        }

        private async void pageNum_ValueChanged(object sender, EventArgs e)
        {
            await reloadComponentDGVAsync();
        }

        private async void pageSize_ValueChanged(object sender, EventArgs e)
        {
            await reloadComponentDGVAsync();
        }

        private async void btnRefreshPlan_Click(object sender, EventArgs e)
        {
            
            await reloadPlanDGVAsync();
        }

        private async void btnCreatePlan_Click(object sender, EventArgs e)
        {
            string message = "Plan created successfully";
            try
            {
                PlanService.getInstance().addNewPlan(getPlanModel());

                await reloadPlanDGVAsync();
            }
            catch(Exception ex)
            {
                message = ex.Message;
            }
            MessageBox.Show(message);
        }

        private async void txtConponentId_TextChanged(object sender, EventArgs e)
        {
            await reloadPlanDGVAsync();
            var m = getPlanModel();
            await reloadModelNameAsync(m.component_id);
            //await reloadCountData();
        }

        private async void txtLineNum_TextChanged(object sender, EventArgs e)
        {
            await reloadPlanDGVAsync();
        }

        private async void btnDeletePlan_Click(object sender, EventArgs e)
        {
            await deleteCurrentPlanAsync();
        }

        private async void planPageNum_ValueChanged(object sender, EventArgs e)
        {
            await reloadPlanDGVAsync();
        }

        private async void planPageSize_ValueChanged(object sender, EventArgs e)
        {
            await reloadPlanDGVAsync();
        }

        private async void Line_Shown(object sender, EventArgs e)
        {
            //
        }

        private async void Line_Activated(object sender, EventArgs e)
        {
            await reloadComponentDGVAsync();
            await reloadPlanDGVAsync();
        }

        private void txtConponentName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
