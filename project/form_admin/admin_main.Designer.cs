namespace project.form_admin
{
    partial class admin_main
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("사용자 추가");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("사용자 정보");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("사용자 관리", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "노드2";
            treeNode1.Text = "사용자 추가";
            treeNode2.Name = "노드1";
            treeNode2.Text = "사용자 정보";
            treeNode3.Name = "노드0";
            treeNode3.Text = "사용자 관리";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(158, 460);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(155, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 456);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // admin_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "admin_main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "인사관리프로그램 - 관리자";
            this.Load += new System.EventHandler(this.admin_main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
    }
}