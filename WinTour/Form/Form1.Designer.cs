namespace WinTour
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabCauhinh.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTinhThanh)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabCauhinh);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(489, 382);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(481, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabCauhinh.Controls.Add(this.tabControl2);
            this.tabCauhinh.Location = new System.Drawing.Point(4, 22);
            this.tabCauhinh.Name = "tabCauhinh";
            this.tabCauhinh.Padding = new System.Windows.Forms.Padding(3);
            this.tabCauhinh.Size = new System.Drawing.Size(481, 356);
            this.tabCauhinh.TabIndex = 2;
            this.tabCauhinh.Text = "Cấu hình";
            this.tabCauhinh.UseVisualStyleBackColor = true;
            this.tabCauhinh.Enter += new System.EventHandler(this.tabCauhinh_Enter);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(7, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(468, 344);
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
            this.tabPage4.Size = new System.Drawing.Size(460, 318);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Tỉnh thành";
            // 
            // btnSuaTinh
            // 
            this.btnSuaTinh.Location = new System.Drawing.Point(236, 113);
            this.btnSuaTinh.Name = "btnSuaTinh";
            this.btnSuaTinh.Size = new System.Drawing.Size(75, 23);
            this.btnSuaTinh.TabIndex = 13;
            this.btnSuaTinh.Text = "Sửa";
            this.btnSuaTinh.UseVisualStyleBackColor = true;
            this.btnSuaTinh.Click += new System.EventHandler(this.btnSuaTinh_Click);
            // 
            // txtTenTinh
            // 
            this.txtTenTinh.Location = new System.Drawing.Point(192, 65);
            this.txtTenTinh.Name = "txtTenTinh";
            this.txtTenTinh.Size = new System.Drawing.Size(100, 20);
            this.txtTenTinh.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên tỉnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 27);
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
            this.GridTinhThanh.Location = new System.Drawing.Point(98, 152);
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
            this.btnThemTinh.Location = new System.Drawing.Point(126, 113);
            this.btnThemTinh.Name = "btnThemTinh";
            this.btnThemTinh.Size = new System.Drawing.Size(75, 23);
            this.btnThemTinh.TabIndex = 8;
            this.btnThemTinh.Text = "Thêm";
            this.btnThemTinh.UseVisualStyleBackColor = true;
            this.btnThemTinh.Click += new System.EventHandler(this.btnThemTinh_Click);
            // 
            // txtMaTinh
            // 
            this.txtMaTinh.Location = new System.Drawing.Point(192, 24);
            this.txtMaTinh.Name = "txtMaTinh";
            this.txtMaTinh.Size = new System.Drawing.Size(100, 20);
            this.txtMaTinh.TabIndex = 7;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(460, 318);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 387);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabCauhinh.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTinhThanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.TabPage tabPage5;
    }
}

