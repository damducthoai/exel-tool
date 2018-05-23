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
            reloadModelName();

            //dateTimePicker.Format = DateTimePickerFormat.Custom;
            //dateTimePicker.CustomFormat = "dd/MM/yyyy";
            txtPlanTime.Text = getCurrentDate();
            reloadComponentDGV();
            //reloadPlanDGVAsync();
        }

        private async void btnRefreshComponent_Click(object sender, EventArgs e)
        {
            await reloadComponentDGVAsync();
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

        private void btnCreatePlan_Click(object sender, EventArgs e)
        {
            string message = "Plan created successfully";
            try
            {
                PlanService.getInstance().addNewPlan(getPlanModel());
            }catch(Exception ex)
            {
                message = ex.Message;
            }
            MessageBox.Show(message);
        }

        private async void txtConponentId_TextChanged(object sender, EventArgs e)
        {
            await reloadPlanDGVAsync();
        }

        private async void txtLineNum_TextChanged(object sender, EventArgs e)
        {
            await reloadPlanDGVAsync();
        }

        private async void btnDeletePlan_Click(object sender, EventArgs e)
        {
            await deleteCurrentPlanAsync();
        }
    }
}
