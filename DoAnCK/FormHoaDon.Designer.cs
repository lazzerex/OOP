﻿namespace DoAnCK
{
    partial class FormHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data_hd = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id_hd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap_hd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanvienlap_hd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnccch_hd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien_hd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_hd)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_hd
            // 
            this.data_hd.AllowUserToAddRows = false;
            this.data_hd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.data_hd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_hd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_hd.ColumnHeadersHeight = 25;
            this.data_hd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.data_hd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_hd,
            this.ngaylap_hd,
            this.nhanvienlap_hd,
            this.idnccch_hd,
            this.tongtien_hd});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_hd.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_hd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.data_hd.Location = new System.Drawing.Point(0, 109);
            this.data_hd.Name = "data_hd";
            this.data_hd.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_hd.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data_hd.RowHeadersWidth = 51;
            this.data_hd.RowTemplate.Height = 24;
            this.data_hd.Size = new System.Drawing.Size(1229, 523);
            this.data_hd.TabIndex = 7;
            this.data_hd.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Cyan;
            this.data_hd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.data_hd.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.data_hd.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.data_hd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.data_hd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.data_hd.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.data_hd.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.data_hd.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.data_hd.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_hd.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_hd.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.data_hd.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.data_hd.ThemeStyle.HeaderStyle.Height = 25;
            this.data_hd.ThemeStyle.ReadOnly = true;
            this.data_hd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.data_hd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_hd.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_hd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.data_hd.ThemeStyle.RowsStyle.Height = 24;
            this.data_hd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.data_hd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.data_hd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_hd_CellDoubleClick);
            // 
            // id_hd
            // 
            this.id_hd.HeaderText = "ID";
            this.id_hd.MinimumWidth = 6;
            this.id_hd.Name = "id_hd";
            this.id_hd.ReadOnly = true;
            // 
            // ngaylap_hd
            // 
            this.ngaylap_hd.HeaderText = "Ngày Lập";
            this.ngaylap_hd.MinimumWidth = 6;
            this.ngaylap_hd.Name = "ngaylap_hd";
            this.ngaylap_hd.ReadOnly = true;
            // 
            // nhanvienlap_hd
            // 
            this.nhanvienlap_hd.HeaderText = "Nhân Viên Lập";
            this.nhanvienlap_hd.MinimumWidth = 6;
            this.nhanvienlap_hd.Name = "nhanvienlap_hd";
            this.nhanvienlap_hd.ReadOnly = true;
            // 
            // idnccch_hd
            // 
            this.idnccch_hd.HeaderText = "ID Nhà Cung Cấp/Cửa Hàng";
            this.idnccch_hd.MinimumWidth = 6;
            this.idnccch_hd.Name = "idnccch_hd";
            this.idnccch_hd.ReadOnly = true;
            // 
            // tongtien_hd
            // 
            this.tongtien_hd.HeaderText = "Tổng Tiền";
            this.tongtien_hd.MinimumWidth = 6;
            this.tongtien_hd.Name = "tongtien_hd";
            this.tongtien_hd.ReadOnly = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1229, 101);
            this.guna2GradientPanel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Hóa Đơn Xuất/Nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 637);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.data_hd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.HoaDon_load);
            ((System.ComponentModel.ISupportInitialize)(this.data_hd)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView data_hd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_hd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap_hd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanvienlap_hd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnccch_hd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien_hd;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label1;
    }
}