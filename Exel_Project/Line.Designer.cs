namespace Exel_Project
{
    partial class Line
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshComponent = new System.Windows.Forms.Button();
            this.btnSearchComponent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchString = new System.Windows.Forms.TextBox();
            this.pageSize = new System.Windows.Forms.NumericUpDown();
            this.pageNum = new System.Windows.Forms.NumericUpDown();
            this.txtConponentName = new System.Windows.Forms.TextBox();
            this.txtConponentId = new System.Windows.Forms.TextBox();
            this.dgvComponent = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeletePlan = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.planPageSize = new System.Windows.Forms.NumericUpDown();
            this.planPageNum = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPlanTime = new System.Windows.Forms.TextBox();
            this.txtPlanId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreatePlan = new System.Windows.Forms.Button();
            this.txtLineNum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlanValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRefreshPlan = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.planDGV = new System.Windows.Forms.DataGridView();
            this.txtKitting = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNhanLe = new System.Windows.Forms.TextBox();
            this.txtChiaCat = new System.Windows.Forms.TextBox();
            this.txtPgm = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponent)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planPageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planPageNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPgm);
            this.groupBox1.Controls.Add(this.txtChiaCat);
            this.groupBox1.Controls.Add(this.txtNhanLe);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtKitting);
            this.groupBox1.Controls.Add(this.btnRefreshComponent);
            this.groupBox1.Controls.Add(this.btnSearchComponent);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearchString);
            this.groupBox1.Controls.Add(this.pageSize);
            this.groupBox1.Controls.Add(this.pageNum);
            this.groupBox1.Controls.Add(this.txtConponentName);
            this.groupBox1.Controls.Add(this.txtConponentId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "component";
            // 
            // btnRefreshComponent
            // 
            this.btnRefreshComponent.Location = new System.Drawing.Point(263, 151);
            this.btnRefreshComponent.Name = "btnRefreshComponent";
            this.btnRefreshComponent.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshComponent.TabIndex = 11;
            this.btnRefreshComponent.Text = "Refresh";
            this.btnRefreshComponent.UseVisualStyleBackColor = true;
            this.btnRefreshComponent.Click += new System.EventHandler(this.btnRefreshComponent_Click);
            // 
            // btnSearchComponent
            // 
            this.btnSearchComponent.Location = new System.Drawing.Point(168, 151);
            this.btnSearchComponent.Name = "btnSearchComponent";
            this.btnSearchComponent.Size = new System.Drawing.Size(75, 23);
            this.btnSearchComponent.TabIndex = 10;
            this.btnSearchComponent.Text = "Search";
            this.btnSearchComponent.UseVisualStyleBackColor = true;
            this.btnSearchComponent.Click += new System.EventHandler(this.btnSearchComponent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "page";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(9, 68);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(33, 13);
            this.lbname.TabIndex = 6;
            this.lbname.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "id";
            // 
            // txtSearchString
            // 
            this.txtSearchString.Location = new System.Drawing.Point(50, 151);
            this.txtSearchString.Name = "txtSearchString";
            this.txtSearchString.Size = new System.Drawing.Size(100, 20);
            this.txtSearchString.TabIndex = 4;
            // 
            // pageSize
            // 
            this.pageSize.Location = new System.Drawing.Point(218, 183);
            this.pageSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.pageSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageSize.Name = "pageSize";
            this.pageSize.Size = new System.Drawing.Size(120, 20);
            this.pageSize.TabIndex = 3;
            this.pageSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.pageSize.ValueChanged += new System.EventHandler(this.pageSize_ValueChanged);
            // 
            // pageNum
            // 
            this.pageNum.Location = new System.Drawing.Point(50, 183);
            this.pageNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageNum.Name = "pageNum";
            this.pageNum.Size = new System.Drawing.Size(120, 20);
            this.pageNum.TabIndex = 2;
            this.pageNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageNum.ValueChanged += new System.EventHandler(this.pageNum_ValueChanged);
            // 
            // txtConponentName
            // 
            this.txtConponentName.Location = new System.Drawing.Point(50, 65);
            this.txtConponentName.Name = "txtConponentName";
            this.txtConponentName.ReadOnly = true;
            this.txtConponentName.Size = new System.Drawing.Size(100, 20);
            this.txtConponentName.TabIndex = 1;
            // 
            // txtConponentId
            // 
            this.txtConponentId.Location = new System.Drawing.Point(50, 28);
            this.txtConponentId.Name = "txtConponentId";
            this.txtConponentId.ReadOnly = true;
            this.txtConponentId.Size = new System.Drawing.Size(100, 20);
            this.txtConponentId.TabIndex = 0;
            this.txtConponentId.TextChanged += new System.EventHandler(this.txtConponentId_TextChanged);
            // 
            // dgvComponent
            // 
            this.dgvComponent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComponent.Location = new System.Drawing.Point(3, 227);
            this.dgvComponent.Name = "dgvComponent";
            this.dgvComponent.Size = new System.Drawing.Size(436, 331);
            this.dgvComponent.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvComponent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.planDGV, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 561);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeletePlan);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.planPageSize);
            this.groupBox2.Controls.Add(this.planPageNum);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPlanTime);
            this.groupBox2.Controls.Add(this.txtPlanId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnCreatePlan);
            this.groupBox2.Controls.Add(this.txtLineNum);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPlanValue);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnRefreshPlan);
            this.groupBox2.Controls.Add(this.txtModel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(445, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 218);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "plan";
            // 
            // btnDeletePlan
            // 
            this.btnDeletePlan.Location = new System.Drawing.Point(220, 179);
            this.btnDeletePlan.Name = "btnDeletePlan";
            this.btnDeletePlan.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePlan.TabIndex = 24;
            this.btnDeletePlan.Text = "Delete Plan";
            this.btnDeletePlan.UseVisualStyleBackColor = true;
            this.btnDeletePlan.Click += new System.EventHandler(this.btnDeletePlan_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(223, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "size";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(217, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "page";
            // 
            // planPageSize
            // 
            this.planPageSize.Location = new System.Drawing.Point(265, 60);
            this.planPageSize.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.planPageSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.planPageSize.Name = "planPageSize";
            this.planPageSize.Size = new System.Drawing.Size(120, 20);
            this.planPageSize.TabIndex = 21;
            this.planPageSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.planPageSize.ValueChanged += new System.EventHandler(this.planPageSize_ValueChanged);
            // 
            // planPageNum
            // 
            this.planPageNum.Location = new System.Drawing.Point(265, 25);
            this.planPageNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.planPageNum.Name = "planPageNum";
            this.planPageNum.Size = new System.Drawing.Size(120, 20);
            this.planPageNum.TabIndex = 20;
            this.planPageNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.planPageNum.ValueChanged += new System.EventHandler(this.planPageNum_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "time";
            // 
            // txtPlanTime
            // 
            this.txtPlanTime.Location = new System.Drawing.Point(57, 154);
            this.txtPlanTime.Name = "txtPlanTime";
            this.txtPlanTime.ReadOnly = true;
            this.txtPlanTime.Size = new System.Drawing.Size(121, 20);
            this.txtPlanTime.TabIndex = 18;
            // 
            // txtPlanId
            // 
            this.txtPlanId.Location = new System.Drawing.Point(57, 20);
            this.txtPlanId.Name = "txtPlanId";
            this.txtPlanId.ReadOnly = true;
            this.txtPlanId.Size = new System.Drawing.Size(121, 20);
            this.txtPlanId.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "id";
            // 
            // btnCreatePlan
            // 
            this.btnCreatePlan.Location = new System.Drawing.Point(117, 180);
            this.btnCreatePlan.Name = "btnCreatePlan";
            this.btnCreatePlan.Size = new System.Drawing.Size(75, 23);
            this.btnCreatePlan.TabIndex = 14;
            this.btnCreatePlan.Text = "Create Plan";
            this.btnCreatePlan.UseVisualStyleBackColor = true;
            this.btnCreatePlan.Click += new System.EventHandler(this.btnCreatePlan_Click);
            // 
            // txtLineNum
            // 
            this.txtLineNum.FormattingEnabled = true;
            this.txtLineNum.Location = new System.Drawing.Point(57, 119);
            this.txtLineNum.Name = "txtLineNum";
            this.txtLineNum.Size = new System.Drawing.Size(121, 21);
            this.txtLineNum.TabIndex = 13;
            this.txtLineNum.TextChanged += new System.EventHandler(this.txtLineNum_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "line";
            // 
            // txtPlanValue
            // 
            this.txtPlanValue.Location = new System.Drawing.Point(57, 83);
            this.txtPlanValue.Name = "txtPlanValue";
            this.txtPlanValue.Size = new System.Drawing.Size(121, 20);
            this.txtPlanValue.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "data";
            // 
            // btnRefreshPlan
            // 
            this.btnRefreshPlan.Location = new System.Drawing.Point(8, 180);
            this.btnRefreshPlan.Name = "btnRefreshPlan";
            this.btnRefreshPlan.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshPlan.TabIndex = 3;
            this.btnRefreshPlan.Text = "Refresh";
            this.btnRefreshPlan.UseVisualStyleBackColor = true;
            this.btnRefreshPlan.Click += new System.EventHandler(this.btnRefreshPlan_Click);
            // 
            // txtModel
            // 
            this.txtModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtModel.FormattingEnabled = true;
            this.txtModel.Location = new System.Drawing.Point(57, 48);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 21);
            this.txtModel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "model";
            // 
            // planDGV
            // 
            this.planDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planDGV.Location = new System.Drawing.Point(445, 227);
            this.planDGV.Name = "planDGV";
            this.planDGV.Size = new System.Drawing.Size(436, 331);
            this.planDGV.TabIndex = 3;
            // 
            // txtKitting
            // 
            this.txtKitting.Location = new System.Drawing.Point(263, 22);
            this.txtKitting.Name = "txtKitting";
            this.txtKitting.Size = new System.Drawing.Size(146, 20);
            this.txtKitting.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(202, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "kitting";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(202, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "nhan le";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(202, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "chia cat";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(202, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "pgm tra ve";
            // 
            // txtNhanLe
            // 
            this.txtNhanLe.Location = new System.Drawing.Point(263, 55);
            this.txtNhanLe.Name = "txtNhanLe";
            this.txtNhanLe.Size = new System.Drawing.Size(146, 20);
            this.txtNhanLe.TabIndex = 17;
            // 
            // txtChiaCat
            // 
            this.txtChiaCat.Location = new System.Drawing.Point(263, 83);
            this.txtChiaCat.Name = "txtChiaCat";
            this.txtChiaCat.Size = new System.Drawing.Size(146, 20);
            this.txtChiaCat.TabIndex = 18;
            // 
            // txtPgm
            // 
            this.txtPgm.Location = new System.Drawing.Point(263, 118);
            this.txtPgm.Name = "txtPgm";
            this.txtPgm.Size = new System.Drawing.Size(146, 20);
            this.txtPgm.TabIndex = 19;
            // 
            // Line
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Line";
            this.Text = "Line";
            this.Activated += new System.EventHandler(this.Line_Activated);
            this.Shown += new System.EventHandler(this.Line_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponent)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planPageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planPageNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefreshComponent;
        private System.Windows.Forms.Button btnSearchComponent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchString;
        private System.Windows.Forms.NumericUpDown pageSize;
        private System.Windows.Forms.NumericUpDown pageNum;
        private System.Windows.Forms.TextBox txtConponentName;
        private System.Windows.Forms.TextBox txtConponentId;
        private System.Windows.Forms.DataGridView dgvComponent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox txtModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefreshPlan;
        private System.Windows.Forms.ComboBox txtLineNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlanValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreatePlan;
        private System.Windows.Forms.TextBox txtPlanId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPlanTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown planPageSize;
        private System.Windows.Forms.NumericUpDown planPageNum;
        private System.Windows.Forms.DataGridView planDGV;
        private System.Windows.Forms.Button btnDeletePlan;
        private System.Windows.Forms.TextBox txtPgm;
        private System.Windows.Forms.TextBox txtChiaCat;
        private System.Windows.Forms.TextBox txtNhanLe;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtKitting;
    }
}