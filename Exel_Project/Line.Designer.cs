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
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.ComboBox();
            this.btnRefreshPlan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponent)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.label4.Location = new System.Drawing.Point(177, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
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
            this.pageSize.Location = new System.Drawing.Point(218, 108);
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
            this.pageNum.Location = new System.Drawing.Point(50, 108);
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
            this.txtConponentName.Enabled = false;
            this.txtConponentName.Location = new System.Drawing.Point(50, 65);
            this.txtConponentName.Name = "txtConponentName";
            this.txtConponentName.Size = new System.Drawing.Size(100, 20);
            this.txtConponentName.TabIndex = 1;
            // 
            // txtConponentId
            // 
            this.txtConponentId.Enabled = false;
            this.txtConponentId.Location = new System.Drawing.Point(50, 28);
            this.txtConponentId.Name = "txtConponentId";
            this.txtConponentId.Size = new System.Drawing.Size(100, 20);
            this.txtConponentId.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "model";
            // 
            // txtModel
            // 
            this.txtModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtModel.FormattingEnabled = true;
            this.txtModel.Location = new System.Drawing.Point(57, 23);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 21);
            this.txtModel.TabIndex = 2;
            // 
            // btnRefreshPlan
            // 
            this.btnRefreshPlan.Location = new System.Drawing.Point(10, 151);
            this.btnRefreshPlan.Name = "btnRefreshPlan";
            this.btnRefreshPlan.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshPlan.TabIndex = 3;
            this.btnRefreshPlan.Text = "Refresh";
            this.btnRefreshPlan.UseVisualStyleBackColor = true;
            this.btnRefreshPlan.Click += new System.EventHandler(this.btnRefreshPlan_Click);
            // 
            // Line
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Line";
            this.Text = "Line";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponent)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}