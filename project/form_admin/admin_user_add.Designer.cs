namespace project.form_admin
{
    partial class admin_user_add
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
            this.label1 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.idbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pwbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.levelbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F);
            this.label1.Location = new System.Drawing.Point(183, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("굴림", 18F);
            this.addbutton.Location = new System.Drawing.Point(188, 292);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(302, 50);
            this.addbutton.TabIndex = 1;
            this.addbutton.Text = "추가하기";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // idbox
            // 
            this.idbox.Font = new System.Drawing.Font("굴림", 18F);
            this.idbox.Location = new System.Drawing.Point(335, 97);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(155, 42);
            this.idbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F);
            this.label2.Location = new System.Drawing.Point(183, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "비밀번호";
            // 
            // pwbox
            // 
            this.pwbox.Font = new System.Drawing.Font("굴림", 18F);
            this.pwbox.Location = new System.Drawing.Point(335, 154);
            this.pwbox.Name = "pwbox";
            this.pwbox.Size = new System.Drawing.Size(155, 42);
            this.pwbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 18F);
            this.label3.Location = new System.Drawing.Point(183, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "권한";
            // 
            // levelbox
            // 
            this.levelbox.Font = new System.Drawing.Font("굴림", 18F);
            this.levelbox.FormattingEnabled = true;
            this.levelbox.ItemHeight = 30;
            this.levelbox.Items.AddRange(new object[] {
            "사용자",
            "관리자"});
            this.levelbox.Location = new System.Drawing.Point(335, 211);
            this.levelbox.Name = "levelbox";
            this.levelbox.ScrollAlwaysVisible = true;
            this.levelbox.Size = new System.Drawing.Size(155, 64);
            this.levelbox.TabIndex = 6;
            this.levelbox.SelectedIndexChanged += new System.EventHandler(this.levelbox_SelectedIndexChanged);
            // 
            // admin_user_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 456);
            this.Controls.Add(this.levelbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pwbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_user_add";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_user_add";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admin_user_add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pwbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox levelbox;
    }
}