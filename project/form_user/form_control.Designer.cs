namespace project.form_user
{
    partial class form_control
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
            this.cancel_b = new System.Windows.Forms.Button();
            this.apply_b = new System.Windows.Forms.Button();
            this.delete_b = new System.Windows.Forms.Button();
            this.update_b = new System.Windows.Forms.Button();
            this.insert_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancel_b
            // 
            this.cancel_b.Location = new System.Drawing.Point(438, 8);
            this.cancel_b.Name = "cancel_b";
            this.cancel_b.Size = new System.Drawing.Size(97, 35);
            this.cancel_b.TabIndex = 16;
            this.cancel_b.Text = "취소";
            this.cancel_b.UseVisualStyleBackColor = true;
            this.cancel_b.Click += new System.EventHandler(this.cancel_b_Click);
            // 
            // apply_b
            // 
            this.apply_b.Location = new System.Drawing.Point(335, 8);
            this.apply_b.Name = "apply_b";
            this.apply_b.Size = new System.Drawing.Size(97, 35);
            this.apply_b.TabIndex = 15;
            this.apply_b.Text = "적용";
            this.apply_b.UseVisualStyleBackColor = true;
            this.apply_b.Click += new System.EventHandler(this.apply_b_Click);
            // 
            // delete_b
            // 
            this.delete_b.AutoSize = true;
            this.delete_b.Location = new System.Drawing.Point(231, 8);
            this.delete_b.Name = "delete_b";
            this.delete_b.Size = new System.Drawing.Size(97, 35);
            this.delete_b.TabIndex = 12;
            this.delete_b.Text = "삭제";
            this.delete_b.UseVisualStyleBackColor = true;
            this.delete_b.Click += new System.EventHandler(this.delete_b_Click);
            // 
            // update_b
            // 
            this.update_b.Location = new System.Drawing.Point(128, 8);
            this.update_b.Name = "update_b";
            this.update_b.Size = new System.Drawing.Size(97, 35);
            this.update_b.TabIndex = 13;
            this.update_b.Text = "수정";
            this.update_b.UseVisualStyleBackColor = true;
            this.update_b.Click += new System.EventHandler(this.update_b_Click);
            // 
            // insert_b
            // 
            this.insert_b.AutoSize = true;
            this.insert_b.Location = new System.Drawing.Point(28, 8);
            this.insert_b.Name = "insert_b";
            this.insert_b.Size = new System.Drawing.Size(94, 35);
            this.insert_b.TabIndex = 14;
            this.insert_b.Text = "입력";
            this.insert_b.UseVisualStyleBackColor = true;
            this.insert_b.Click += new System.EventHandler(this.insert_b_Click);
            // 
            // form_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1271, 50);
            this.Controls.Add(this.cancel_b);
            this.Controls.Add(this.apply_b);
            this.Controls.Add(this.delete_b);
            this.Controls.Add(this.update_b);
            this.Controls.Add(this.insert_b);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_control";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "form_control";
            this.Load += new System.EventHandler(this.form_control_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_b;
        private System.Windows.Forms.Button apply_b;
        private System.Windows.Forms.Button delete_b;
        private System.Windows.Forms.Button update_b;
        private System.Windows.Forms.Button insert_b;
    }
}