namespace loadDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.p_btn = new System.Windows.Forms.Panel();
            this.btnQlMonHoc = new System.Windows.Forms.Button();
            this.btnQLKhoa = new System.Windows.Forms.Button();
            this.btnQLSinhVien = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.p_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 99);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.75846F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.24154F));
            this.tableLayoutPanel1.Controls.Add(this.p_btn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelBody, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1271, 552);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // p_btn
            // 
            this.p_btn.BackColor = System.Drawing.Color.Silver;
            this.p_btn.Controls.Add(this.btnQlMonHoc);
            this.p_btn.Controls.Add(this.btnQLKhoa);
            this.p_btn.Controls.Add(this.btnQLSinhVien);
            this.p_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_btn.Location = new System.Drawing.Point(3, 3);
            this.p_btn.Name = "p_btn";
            this.p_btn.Size = new System.Drawing.Size(207, 546);
            this.p_btn.TabIndex = 0;
            // 
            // btnQlMonHoc
            // 
            this.btnQlMonHoc.FlatAppearance.BorderSize = 0;
            this.btnQlMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQlMonHoc.Location = new System.Drawing.Point(0, 176);
            this.btnQlMonHoc.Name = "btnQlMonHoc";
            this.btnQlMonHoc.Size = new System.Drawing.Size(207, 55);
            this.btnQlMonHoc.TabIndex = 2;
            this.btnQlMonHoc.Text = "QL Môn Học";
            this.btnQlMonHoc.UseVisualStyleBackColor = true;
            // 
            // btnQLKhoa
            // 
            this.btnQLKhoa.FlatAppearance.BorderSize = 0;
            this.btnQLKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKhoa.Location = new System.Drawing.Point(0, 128);
            this.btnQLKhoa.Name = "btnQLKhoa";
            this.btnQLKhoa.Size = new System.Drawing.Size(207, 55);
            this.btnQLKhoa.TabIndex = 1;
            this.btnQLKhoa.Text = "QL Khoa";
            this.btnQLKhoa.UseVisualStyleBackColor = true;
            // 
            // btnQLSinhVien
            // 
            this.btnQLSinhVien.FlatAppearance.BorderSize = 0;
            this.btnQLSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSinhVien.Location = new System.Drawing.Point(0, 76);
            this.btnQLSinhVien.Name = "btnQLSinhVien";
            this.btnQLSinhVien.Size = new System.Drawing.Size(207, 55);
            this.btnQLSinhVien.TabIndex = 0;
            this.btnQLSinhVien.Text = "QL Sinh Viên";
            this.btnQLSinhVien.UseVisualStyleBackColor = true;
            this.btnQLSinhVien.Click += new System.EventHandler(this.btnQLSinhVien_Click);
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(216, 3);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1052, 546);
            this.panelBody.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 659);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.p_btn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel p_btn;
        private System.Windows.Forms.Button btnQLKhoa;
        private System.Windows.Forms.Button btnQLSinhVien;
        private System.Windows.Forms.Button btnQlMonHoc;
        private System.Windows.Forms.Panel panelBody;
    }
}

