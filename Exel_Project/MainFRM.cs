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
    public partial class MainFRM : Form
    {
        BOM bom = null;
        Line line = null;
        public MainFRM()
        {
            InitializeComponent();
            loadLine();
        }
        void loadBom()
        {
            if (bom == null) bom = new BOM();
            if (bom.IsDisposed) bom = new BOM();
            bom.MdiParent = this;
            bom.Show();
            //bom.Activate();
            bom.WindowState = FormWindowState.Maximized;
        }

        private void bomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadBom();
        }

        void loadLine()
        {
            if (line == null) line = new Line();
            if (line.IsDisposed) line = new Line();
            line.MdiParent = this;

            line.Show();
            line.WindowState = FormWindowState.Maximized;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadLine();
        }
    }
}
