﻿namespace WinTour
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTour = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabCauhinh = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnSuaTinh = new System.Windows.Forms.Button();
            this.txtTenTinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GridTinhThanh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemTinh = new System.Windows.Forms.Button();
            this.txtMaTinh = new System.Windows.Forms.TextBox();
            this.tabDD = new System.Windows.Forms.TabPage();
            this.cbTinhThanh = new System.Windows.Forms.ComboBox();
            this.txtSuaDD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GridDD = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtThemDD = new System.Windows.Forms.Button();
            this.txtTenDD = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLoaiDL = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDacDiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDSDDTuor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GridDDTour = new System.Windows.Forms.DataGridView();
            this.txtGiaTour = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabTour.SuspendLayout();
            this.tabCauhinh.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTinhThanh)).BeginInit();
            this.tabDD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDD)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDDTour)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTour);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabCauhinh);
            this.tabControl.Location = new System.Drawing.Point(1, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(505, 431);
            this.tabControl.TabIndex = 0;
            // 
            // tabTour
            // 
            this.tabTour.Controls.Add(this.tabControl1);
            this.tabTour.Location = new System.Drawing.Point(4, 22);
            this.tabTour.Name = "tabTour";
            this.tabTour.Padding = new System.Windows.Forms.Padding(3);
            this.tabTour.Size = new System.Drawing.Size(497, 405);
            this.tabTour.TabIndex = 0;
            this.tabTour.Text = "QLTour";
            this.tabTour.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(481, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabCauhinh
            // 
            this.tabCauhinh.BackColor = System.Drawing.Color.White;
            this.tabCauhinh.Controls.Add(this.tabControl2);
            this.tabCauhinh.Location = new System.Drawing.Point(4, 22);
            this.tabCauhinh.Name = "tabCauhinh";
            this.tabCauhinh.Padding = new System.Windows.Forms.Padding(3);
            this.tabCauhinh.Size = new System.Drawing.Size(497, 405);
            this.tabCauhinh.TabIndex = 2;
            this.tabCauhinh.Text = "Cấu hình";
            this.tabCauhinh.Enter += new System.EventHandler(this.tabCauhinh_Enter);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabDD);
            this.tabControl2.Location = new System.Drawing.Point(7, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(471, 374);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.btnSuaTinh);
            this.tabPage4.Controls.Add(this.txtTenTinh);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.GridTinhThanh);
            this.tabPage4.Controls.Add(this.btnThemTinh);
            this.tabPage4.Controls.Add(this.txtMaTinh);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(463, 348);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Tỉnh thành";
            // 
            // btnSuaTinh
            // 
            this.btnSuaTinh.Location = new System.Drawing.Point(230, 127);
            this.btnSuaTinh.Name = "btnSuaTinh";
            this.btnSuaTinh.Size = new System.Drawing.Size(75, 23);
            this.btnSuaTinh.TabIndex = 13;
            this.btnSuaTinh.Text = "Sửa";
            this.btnSuaTinh.UseVisualStyleBackColor = true;
            this.btnSuaTinh.Click += new System.EventHandler(this.btnSuaTinh_Click);
            // 
            // txtTenTinh
            // 
            this.txtTenTinh.Location = new System.Drawing.Point(186, 79);
            this.txtTenTinh.Name = "txtTenTinh";
            this.txtTenTinh.Size = new System.Drawing.Size(100, 20);
            this.txtTenTinh.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên tỉnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã tỉnh";
            // 
            // GridTinhThanh
            // 
            this.GridTinhThanh.AllowUserToAddRows = false;
            this.GridTinhThanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTinhThanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.GridTinhThanh.Location = new System.Drawing.Point(92, 166);
            this.GridTinhThanh.Name = "GridTinhThanh";
            this.GridTinhThanh.Size = new System.Drawing.Size(240, 150);
            this.GridTinhThanh.TabIndex = 9;
            this.GridTinhThanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTinhThanh_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã tỉnh";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Tỉnh";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // btnThemTinh
            // 
            this.btnThemTinh.Location = new System.Drawing.Point(120, 127);
            this.btnThemTinh.Name = "btnThemTinh";
            this.btnThemTinh.Size = new System.Drawing.Size(75, 23);
            this.btnThemTinh.TabIndex = 8;
            this.btnThemTinh.Text = "Thêm";
            this.btnThemTinh.UseVisualStyleBackColor = true;
            this.btnThemTinh.Click += new System.EventHandler(this.btnThemTinh_Click);
            // 
            // txtMaTinh
            // 
            this.txtMaTinh.Location = new System.Drawing.Point(186, 38);
            this.txtMaTinh.Name = "txtMaTinh";
            this.txtMaTinh.Size = new System.Drawing.Size(100, 20);
            this.txtMaTinh.TabIndex = 7;
            // 
            // tabDD
            // 
            this.tabDD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDD.Controls.Add(this.cbTinhThanh);
            this.tabDD.Controls.Add(this.txtSuaDD);
            this.tabDD.Controls.Add(this.label3);
            this.tabDD.Controls.Add(this.label4);
            this.tabDD.Controls.Add(this.GridDD);
            this.tabDD.Controls.Add(this.txtThemDD);
            this.tabDD.Controls.Add(this.txtTenDD);
            this.tabDD.Location = new System.Drawing.Point(4, 22);
            this.tabDD.Name = "tabDD";
            this.tabDD.Padding = new System.Windows.Forms.Padding(3);
            this.tabDD.Size = new System.Drawing.Size(463, 348);
            this.tabDD.TabIndex = 1;
            this.tabDD.Text = "Đia diểm";
            this.tabDD.Enter += new System.EventHandler(this.tabDD_Enter);
            // 
            // cbTinhThanh
            // 
            this.cbTinhThanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinhThanh.FormattingEnabled = true;
            this.cbTinhThanh.Location = new System.Drawing.Point(192, 76);
            this.cbTinhThanh.Name = "cbTinhThanh";
            this.cbTinhThanh.Size = new System.Drawing.Size(121, 21);
            this.cbTinhThanh.TabIndex = 21;
            this.cbTinhThanh.Click += new System.EventHandler(this.cbTinhThanh_Click);
            // 
            // txtSuaDD
            // 
            this.txtSuaDD.Location = new System.Drawing.Point(236, 126);
            this.txtSuaDD.Name = "txtSuaDD";
            this.txtSuaDD.Size = new System.Drawing.Size(75, 23);
            this.txtSuaDD.TabIndex = 20;
            this.txtSuaDD.Text = "Sửa";
            this.txtSuaDD.UseVisualStyleBackColor = true;
            this.txtSuaDD.Click += new System.EventHandler(this.txtSuaDD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Thuộc tỉnh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tên";
            // 
            // GridDD
            // 
            this.GridDD.AllowUserToAddRows = false;
            this.GridDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.GridDD.Location = new System.Drawing.Point(98, 165);
            this.GridDD.Name = "GridDD";
            this.GridDD.Size = new System.Drawing.Size(240, 150);
            this.GridDD.TabIndex = 16;
            this.GridDD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDD_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Thuộc Tỉnh";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // txtThemDD
            // 
            this.txtThemDD.Location = new System.Drawing.Point(126, 126);
            this.txtThemDD.Name = "txtThemDD";
            this.txtThemDD.Size = new System.Drawing.Size(75, 23);
            this.txtThemDD.TabIndex = 15;
            this.txtThemDD.Text = "Thêm";
            this.txtThemDD.UseVisualStyleBackColor = true;
            this.txtThemDD.Click += new System.EventHandler(this.txtThemDD_Click);
            // 
            // txtTenDD
            // 
            this.txtTenDD.Location = new System.Drawing.Point(192, 37);
            this.txtTenDD.Name = "txtTenDD";
            this.txtTenDD.Size = new System.Drawing.Size(119, 20);
            this.txtTenDD.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(487, 403);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(479, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(465, 348);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.txtGiaTour);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbLoaiDL);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDacDiem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenTour);
            this.groupBox1.Location = new System.Drawing.Point(16, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 82);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tour";
            // 
            // cbLoaiDL
            // 
            this.cbLoaiDL.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbLoaiDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiDL.FormattingEnabled = true;
            this.cbLoaiDL.Location = new System.Drawing.Point(102, 47);
            this.cbLoaiDL.Name = "cbLoaiDL";
            this.cbLoaiDL.Size = new System.Drawing.Size(108, 21);
            this.cbLoaiDL.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(19, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Loại DL";
            // 
            // txtDacDiem
            // 
            this.txtDacDiem.Location = new System.Drawing.Point(314, 17);
            this.txtDacDiem.Name = "txtDacDiem";
            this.txtDacDiem.Size = new System.Drawing.Size(100, 20);
            this.txtDacDiem.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(228, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Đặc điểm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(16, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tên tour";
            // 
            // txtTenTour
            // 
            this.txtTenTour.Location = new System.Drawing.Point(102, 13);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(108, 20);
            this.txtTenTour.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.cbDSDDTuor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.GridDDTour);
            this.groupBox2.Location = new System.Drawing.Point(16, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 218);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DS địa điểm tham quan";
            // 
            // cbDSDDTuor
            // 
            this.cbDSDDTuor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbDSDDTuor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDSDDTuor.FormattingEnabled = true;
            this.cbDSDDTuor.Location = new System.Drawing.Point(84, 26);
            this.cbDSDDTuor.Name = "cbDSDDTuor";
            this.cbDSDDTuor.Size = new System.Drawing.Size(138, 21);
            this.cbDSDDTuor.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(16, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Đia điểm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label8.Location = new System.Drawing.Point(16, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Đặc điểm";
            // 
            // GridDDTour
            // 
            this.GridDDTour.AllowUserToAddRows = false;
            this.GridDDTour.BackgroundColor = System.Drawing.Color.Silver;
            this.GridDDTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDDTour.Location = new System.Drawing.Point(19, 67);
            this.GridDDTour.Name = "GridDDTour";
            this.GridDDTour.Size = new System.Drawing.Size(395, 129);
            this.GridDDTour.TabIndex = 25;
            // 
            // txtGiaTour
            // 
            this.txtGiaTour.Location = new System.Drawing.Point(314, 48);
            this.txtGiaTour.Name = "txtGiaTour";
            this.txtGiaTour.Size = new System.Drawing.Size(100, 20);
            this.txtGiaTour.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(228, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Giá tour";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 433);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabTour.ResumeLayout(false);
            this.tabCauhinh.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTinhThanh)).EndInit();
            this.tabDD.ResumeLayout(false);
            this.tabDD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDD)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDDTour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTour;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabCauhinh;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnSuaTinh;
        private System.Windows.Forms.TextBox txtTenTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridTinhThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnThemTinh;
        private System.Windows.Forms.TextBox txtMaTinh;
        private System.Windows.Forms.TabPage tabDD;
        private System.Windows.Forms.ComboBox cbTinhThanh;
        private System.Windows.Forms.Button txtSuaDD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView GridDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button txtThemDD;
        private System.Windows.Forms.TextBox txtTenDD;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbDSDDTuor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView GridDDTour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbLoaiDL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDacDiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.TextBox txtGiaTour;
        private System.Windows.Forms.Label label10;
    }
}

