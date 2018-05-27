namespace Exel_Project
{
    partial class BOM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBom = new System.Windows.Forms.DataGridView();
            this.dgvBomModel = new System.Windows.Forms.DataGridView();
            this.txtComponentId = new System.Windows.Forms.TextBox();
            this.txtComponentName = new System.Windows.Forms.TextBox();
            this.txtObjectDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateBom = new System.Windows.Forms.Button();
            this.btnDeleteBom = new System.Windows.Forms.Button();
            this.btnRefreshBom = new System.Windows.Forms.Button();
            this.btnSaveBomModel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBomPageSize = new System.Windows.Forms.NumericUpDown();
            this.txtBomPageNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateModel = new System.Windows.Forms.Button();
            this.txtComponentModelQuantity = new System.Windows.Forms.TextBox();
            this.btnDeleteBomModelDetail = new System.Windows.Forms.Button();
            this.btnSaveBomModelDetail = new System.Windows.Forms.Button();
            this.btnRefreshBomModel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBomModelPageSize = new System.Windows.Forms.NumericUpDown();
            this.txtBomModelPageNum = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComponentModelName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBomModel)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBomPageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBomPageNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBomModelPageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBomModelPageNum)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBom
            // 
            this.dgvBom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBom.Location = new System.Drawing.Point(3, 227);
            this.dgvBom.Name = "dgvBom";
            this.dgvBom.Size = new System.Drawing.Size(436, 331);
            this.dgvBom.TabIndex = 0;
            // 
            // dgvBomModel
            // 
            this.dgvBomModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBomModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBomModel.Location = new System.Drawing.Point(445, 227);
            this.dgvBomModel.Name = "dgvBomModel";
            this.dgvBomModel.Size = new System.Drawing.Size(436, 331);
            this.dgvBomModel.TabIndex = 1;
            // 
            // txtComponentId
            // 
            this.txtComponentId.Location = new System.Drawing.Point(34, 19);
            this.txtComponentId.Name = "txtComponentId";
            this.txtComponentId.ReadOnly = true;
            this.txtComponentId.Size = new System.Drawing.Size(40, 20);
            this.txtComponentId.TabIndex = 2;
            this.txtComponentId.TextChanged += new System.EventHandler(this.txtComponentId_TextChanged);
            // 
            // txtComponentName
            // 
            this.txtComponentName.Location = new System.Drawing.Point(146, 19);
            this.txtComponentName.Name = "txtComponentName";
            this.txtComponentName.ReadOnly = true;
            this.txtComponentName.Size = new System.Drawing.Size(207, 20);
            this.txtComponentName.TabIndex = 3;
            // 
            // txtObjectDescription
            // 
            this.txtObjectDescription.Location = new System.Drawing.Point(76, 57);
            this.txtObjectDescription.Name = "txtObjectDescription";
            this.txtObjectDescription.ReadOnly = true;
            this.txtObjectDescription.Size = new System.Drawing.Size(277, 20);
            this.txtObjectDescription.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "component";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "description";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnUpdateBom);
            this.groupBox1.Controls.Add(this.btnDeleteBom);
            this.groupBox1.Controls.Add(this.btnRefreshBom);
            this.groupBox1.Controls.Add(this.btnSaveBomModel);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBomPageSize);
            this.groupBox1.Controls.Add(this.txtBomPageNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtObjectDescription);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtComponentId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtComponentName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 218);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "component";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnUpdateBom
            // 
            this.btnUpdateBom.Location = new System.Drawing.Point(288, 168);
            this.btnUpdateBom.Name = "btnUpdateBom";
            this.btnUpdateBom.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBom.TabIndex = 18;
            this.btnUpdateBom.Text = "Update";
            this.btnUpdateBom.UseVisualStyleBackColor = true;
            this.btnUpdateBom.Click += new System.EventHandler(this.btnUpdateBom_Click);
            // 
            // btnDeleteBom
            // 
            this.btnDeleteBom.Location = new System.Drawing.Point(104, 169);
            this.btnDeleteBom.Name = "btnDeleteBom";
            this.btnDeleteBom.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBom.TabIndex = 17;
            this.btnDeleteBom.Text = "Delete";
            this.btnDeleteBom.UseVisualStyleBackColor = true;
            this.btnDeleteBom.Click += new System.EventHandler(this.btnDeleteBom_Click);
            // 
            // btnRefreshBom
            // 
            this.btnRefreshBom.Location = new System.Drawing.Point(12, 169);
            this.btnRefreshBom.Name = "btnRefreshBom";
            this.btnRefreshBom.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshBom.TabIndex = 16;
            this.btnRefreshBom.Text = "Refresh";
            this.btnRefreshBom.UseVisualStyleBackColor = true;
            this.btnRefreshBom.Click += new System.EventHandler(this.btnRefreshBom_Click);
            // 
            // btnSaveBomModel
            // 
            this.btnSaveBomModel.Location = new System.Drawing.Point(195, 169);
            this.btnSaveBomModel.Name = "btnSaveBomModel";
            this.btnSaveBomModel.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBomModel.TabIndex = 15;
            this.btnSaveBomModel.Text = "Save";
            this.btnSaveBomModel.UseVisualStyleBackColor = true;
            this.btnSaveBomModel.Click += new System.EventHandler(this.btnSaveBomModel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(288, 133);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(60, 135);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(223, 20);
            this.txtSearch.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Search";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "size";
            // 
            // txtBomPageSize
            // 
            this.txtBomPageSize.Location = new System.Drawing.Point(233, 102);
            this.txtBomPageSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtBomPageSize.Name = "txtBomPageSize";
            this.txtBomPageSize.Size = new System.Drawing.Size(120, 20);
            this.txtBomPageSize.TabIndex = 10;
            this.txtBomPageSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtBomPageSize.ValueChanged += new System.EventHandler(this.txtBomPageSize_ValueChanged);
            // 
            // txtBomPageNum
            // 
            this.txtBomPageNum.Location = new System.Drawing.Point(60, 101);
            this.txtBomPageNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtBomPageNum.Name = "txtBomPageNum";
            this.txtBomPageNum.Size = new System.Drawing.Size(120, 20);
            this.txtBomPageNum.TabIndex = 9;
            this.txtBomPageNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtBomPageNum.ValueChanged += new System.EventHandler(this.txtBomPageNum_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "page";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.btnUpdateModel);
            this.groupBox2.Controls.Add(this.txtComponentModelQuantity);
            this.groupBox2.Controls.Add(this.btnDeleteBomModelDetail);
            this.groupBox2.Controls.Add(this.btnSaveBomModelDetail);
            this.groupBox2.Controls.Add(this.btnRefreshBomModel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBomModelPageSize);
            this.groupBox2.Controls.Add(this.txtBomModelPageNum);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtComponentModelName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(445, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 218);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "model";
            // 
            // btnUpdateModel
            // 
            this.btnUpdateModel.Location = new System.Drawing.Point(317, 168);
            this.btnUpdateModel.Name = "btnUpdateModel";
            this.btnUpdateModel.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateModel.TabIndex = 12;
            this.btnUpdateModel.Text = "Update";
            this.btnUpdateModel.UseVisualStyleBackColor = true;
            this.btnUpdateModel.Click += new System.EventHandler(this.btnUpdateModel_Click);
            // 
            // txtComponentModelQuantity
            // 
            this.txtComponentModelQuantity.Location = new System.Drawing.Point(58, 56);
            this.txtComponentModelQuantity.Name = "txtComponentModelQuantity";
            this.txtComponentModelQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtComponentModelQuantity.TabIndex = 11;
            // 
            // btnDeleteBomModelDetail
            // 
            this.btnDeleteBomModelDetail.Location = new System.Drawing.Point(122, 168);
            this.btnDeleteBomModelDetail.Name = "btnDeleteBomModelDetail";
            this.btnDeleteBomModelDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBomModelDetail.TabIndex = 10;
            this.btnDeleteBomModelDetail.Text = "Delete";
            this.btnDeleteBomModelDetail.UseVisualStyleBackColor = true;
            this.btnDeleteBomModelDetail.Click += new System.EventHandler(this.btnDeleteBomModelDetail_Click);
            // 
            // btnSaveBomModelDetail
            // 
            this.btnSaveBomModelDetail.Location = new System.Drawing.Point(221, 168);
            this.btnSaveBomModelDetail.Name = "btnSaveBomModelDetail";
            this.btnSaveBomModelDetail.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBomModelDetail.TabIndex = 9;
            this.btnSaveBomModelDetail.Text = "Save";
            this.btnSaveBomModelDetail.UseVisualStyleBackColor = true;
            this.btnSaveBomModelDetail.Click += new System.EventHandler(this.btnSaveBomModelDetail_Click);
            // 
            // btnRefreshBomModel
            // 
            this.btnRefreshBomModel.Location = new System.Drawing.Point(13, 168);
            this.btnRefreshBomModel.Name = "btnRefreshBomModel";
            this.btnRefreshBomModel.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshBomModel.TabIndex = 8;
            this.btnRefreshBomModel.Text = "Refresh";
            this.btnRefreshBomModel.UseVisualStyleBackColor = true;
            this.btnRefreshBomModel.Click += new System.EventHandler(this.btnRefreshBomModel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Page";
            // 
            // txtBomModelPageSize
            // 
            this.txtBomModelPageSize.Location = new System.Drawing.Point(246, 101);
            this.txtBomModelPageSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtBomModelPageSize.Name = "txtBomModelPageSize";
            this.txtBomModelPageSize.Size = new System.Drawing.Size(120, 20);
            this.txtBomModelPageSize.TabIndex = 5;
            this.txtBomModelPageSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtBomModelPageSize.ValueChanged += new System.EventHandler(this.txtBomModelPageSize_ValueChanged);
            // 
            // txtBomModelPageNum
            // 
            this.txtBomModelPageNum.Location = new System.Drawing.Point(53, 100);
            this.txtBomModelPageNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtBomModelPageNum.Name = "txtBomModelPageNum";
            this.txtBomModelPageNum.Size = new System.Drawing.Size(120, 20);
            this.txtBomModelPageNum.TabIndex = 4;
            this.txtBomModelPageNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtBomModelPageNum.ValueChanged += new System.EventHandler(this.txtBomModelPageNum_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "point";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "model";
            // 
            // txtComponentModelName
            // 
            this.txtComponentModelName.Location = new System.Drawing.Point(53, 24);
            this.txtComponentModelName.Name = "txtComponentModelName";
            this.txtComponentModelName.ReadOnly = true;
            this.txtComponentModelName.Size = new System.Drawing.Size(100, 20);
            this.txtComponentModelName.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvBomModel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvBom, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 561);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // BOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BOM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBomModel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBomPageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBomPageNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBomModelPageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBomModelPageNum)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBom;
        private System.Windows.Forms.DataGridView dgvBomModel;
        private System.Windows.Forms.TextBox txtComponentId;
        private System.Windows.Forms.TextBox txtComponentName;
        private System.Windows.Forms.TextBox txtObjectDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtBomPageSize;
        private System.Windows.Forms.NumericUpDown txtBomPageNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveBomModel;
        private System.Windows.Forms.Button btnRefreshBom;
        private System.Windows.Forms.Button btnDeleteBom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtComponentModelName;
        private System.Windows.Forms.Button btnDeleteBomModelDetail;
        private System.Windows.Forms.Button btnSaveBomModelDetail;
        private System.Windows.Forms.Button btnRefreshBomModel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtBomModelPageSize;
        private System.Windows.Forms.NumericUpDown txtBomModelPageNum;
        private System.Windows.Forms.TextBox txtComponentModelQuantity;
        private System.Windows.Forms.Button btnUpdateBom;
        private System.Windows.Forms.Button btnUpdateModel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

