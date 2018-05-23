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
    }
}
