namespace PRL.Frm_Main
{
    partial class QuenMatKhau_Frm
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
            groupXacNhan = new GroupBox();
            btnXacNhan_MaXacMinh = new Button();
            btnGuiMa = new Button();
            txtMaXacMinh = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnXacNhan_DoiMatKhau = new Button();
            txtMatKhauMoi_2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMatKhauMoi_1 = new TextBox();
            groupXacNhan.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupXacNhan
            // 
            groupXacNhan.Controls.Add(btnXacNhan_MaXacMinh);
            groupXacNhan.Controls.Add(btnGuiMa);
            groupXacNhan.Controls.Add(txtMaXacMinh);
            groupXacNhan.Controls.Add(label3);
            groupXacNhan.Controls.Add(txtEmail);
            groupXacNhan.Controls.Add(label2);
            groupXacNhan.Controls.Add(label1);
            groupXacNhan.Location = new Point(14, 16);
            groupXacNhan.Margin = new Padding(3, 4, 3, 4);
            groupXacNhan.Name = "groupXacNhan";
            groupXacNhan.Padding = new Padding(3, 4, 3, 4);
            groupXacNhan.Size = new Size(415, 491);
            groupXacNhan.TabIndex = 0;
            groupXacNhan.TabStop = false;
            // 
            // btnXacNhan_MaXacMinh
            // 
            btnXacNhan_MaXacMinh.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnXacNhan_MaXacMinh.Location = new Point(250, 323);
            btnXacNhan_MaXacMinh.Margin = new Padding(3, 4, 3, 4);
            btnXacNhan_MaXacMinh.Name = "btnXacNhan_MaXacMinh";
            btnXacNhan_MaXacMinh.Size = new Size(137, 53);
            btnXacNhan_MaXacMinh.TabIndex = 3;
            btnXacNhan_MaXacMinh.Text = "Xác nhận";
            btnXacNhan_MaXacMinh.UseVisualStyleBackColor = true;
            btnXacNhan_MaXacMinh.Click += btnXacNhan_MaXacMinh_Click;
            // 
            // btnGuiMa
            // 
            btnGuiMa.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuiMa.Location = new Point(250, 163);
            btnGuiMa.Margin = new Padding(3, 4, 3, 4);
            btnGuiMa.Name = "btnGuiMa";
            btnGuiMa.Size = new Size(137, 53);
            btnGuiMa.TabIndex = 1;
            btnGuiMa.Text = "Gửi mã";
            btnGuiMa.UseVisualStyleBackColor = true;
            btnGuiMa.Click += btnGuiMa_Click;
            // 
            // txtMaXacMinh
            // 
            txtMaXacMinh.Location = new Point(24, 269);
            txtMaXacMinh.Margin = new Padding(3, 4, 3, 4);
            txtMaXacMinh.Multiline = true;
            txtMaXacMinh.Name = "txtMaXacMinh";
            txtMaXacMinh.Size = new Size(363, 44);
            txtMaXacMinh.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 245);
            label3.Name = "label3";
            label3.Size = new Size(301, 20);
            label3.TabIndex = 0;
            label3.Text = "Nhập mã xác nhận đã được gửi trong email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(24, 109);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(363, 44);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 85);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 0;
            label2.Text = "Nhập Email của bạn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(103, 25);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 0;
            label1.Text = "Xác nhận thông tin";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXacNhan_DoiMatKhau);
            groupBox2.Controls.Add(txtMatKhauMoi_2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtMatKhauMoi_1);
            groupBox2.Location = new Point(435, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(415, 491);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // btnXacNhan_DoiMatKhau
            // 
            btnXacNhan_DoiMatKhau.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnXacNhan_DoiMatKhau.Location = new Point(249, 261);
            btnXacNhan_DoiMatKhau.Margin = new Padding(3, 4, 3, 4);
            btnXacNhan_DoiMatKhau.Name = "btnXacNhan_DoiMatKhau";
            btnXacNhan_DoiMatKhau.Size = new Size(137, 53);
            btnXacNhan_DoiMatKhau.TabIndex = 6;
            btnXacNhan_DoiMatKhau.Text = "Xác nhận";
            btnXacNhan_DoiMatKhau.UseVisualStyleBackColor = true;
            btnXacNhan_DoiMatKhau.Click += btnXacNhan_DoiMatKhau_Click;
            // 
            // txtMatKhauMoi_2
            // 
            txtMatKhauMoi_2.Location = new Point(23, 208);
            txtMatKhauMoi_2.Margin = new Padding(3, 4, 3, 4);
            txtMatKhauMoi_2.Multiline = true;
            txtMatKhauMoi_2.Name = "txtMatKhauMoi_2";
            txtMatKhauMoi_2.PasswordChar = '*';
            txtMatKhauMoi_2.Size = new Size(363, 44);
            txtMatKhauMoi_2.TabIndex = 5;
            txtMatKhauMoi_2.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(151, 25);
            label4.Name = "label4";
            label4.Size = new Size(162, 32);
            label4.TabIndex = 0;
            label4.Text = "Đổi mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 85);
            label5.Name = "label5";
            label5.Size = new Size(199, 20);
            label5.TabIndex = 0;
            label5.Text = "Nhập mật khẩu mới của bạn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 184);
            label6.Name = "label6";
            label6.Size = new Size(187, 20);
            label6.TabIndex = 0;
            label6.Text = "Xác nhận lại mật khẩu mới:";
            // 
            // txtMatKhauMoi_1
            // 
            txtMatKhauMoi_1.Location = new Point(23, 109);
            txtMatKhauMoi_1.Margin = new Padding(3, 4, 3, 4);
            txtMatKhauMoi_1.Multiline = true;
            txtMatKhauMoi_1.Name = "txtMatKhauMoi_1";
            txtMatKhauMoi_1.PasswordChar = '*';
            txtMatKhauMoi_1.Size = new Size(363, 44);
            txtMatKhauMoi_1.TabIndex = 4;
            txtMatKhauMoi_1.UseSystemPasswordChar = true;
            // 
            // QuenMatKhau_Frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 523);
            Controls.Add(groupBox2);
            Controls.Add(groupXacNhan);
            Margin = new Padding(3, 4, 3, 4);
            Name = "QuenMatKhau_Frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quên Mật Khẩu";
            FormClosed += QuenMatKhau_Frm_FormClosed;
            Load += QuenMatKhau_Frm_Load;
            groupXacNhan.ResumeLayout(false);
            groupXacNhan.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupXacNhan;
        private TextBox txtMaXacMinh;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnXacNhan_MaXacMinh;
        private Button btnGuiMa;
        private Button btnXacNhan_DoiMatKhau;
        private TextBox txtMatKhauMoi_2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMatKhauMoi_1;
    }
}