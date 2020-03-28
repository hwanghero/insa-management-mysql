namespace project.form_user
{
    partial class password_change
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
            this.now_pw = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.c_pw = new System.Windows.Forms.TextBox();
            this.c_pw_check = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(247, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "현재 비밀번호";
            // 
            // now_pw
            // 
            this.now_pw.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.now_pw.Location = new System.Drawing.Point(495, 122);
            this.now_pw.Name = "now_pw";
            this.now_pw.Size = new System.Drawing.Size(294, 42);
            this.now_pw.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(152, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(680, 68);
            this.button2.TabIndex = 3;
            this.button2.Text = "변경하기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(217, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "수정할 비밀번호";
            // 
            // c_pw
            // 
            this.c_pw.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.c_pw.Location = new System.Drawing.Point(495, 190);
            this.c_pw.Name = "c_pw";
            this.c_pw.Size = new System.Drawing.Size(294, 42);
            this.c_pw.TabIndex = 5;
            // 
            // c_pw_check
            // 
            this.c_pw_check.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.c_pw_check.Location = new System.Drawing.Point(495, 254);
            this.c_pw_check.Name = "c_pw_check";
            this.c_pw_check.Size = new System.Drawing.Size(294, 42);
            this.c_pw_check.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(147, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "수정할 비밀번호 확인";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.now_pw);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.c_pw);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.c_pw_check);
            this.groupBox1.Location = new System.Drawing.Point(101, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(987, 465);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(400, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "비밀번호 변경";
            // 
            // password_change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1187, 672);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "password_change";
            this.Text = "password_changecs";
            this.Load += new System.EventHandler(this.password_change_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox now_pw;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox c_pw;
        private System.Windows.Forms.TextBox c_pw_check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
    }
}