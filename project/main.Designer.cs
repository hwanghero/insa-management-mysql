namespace project
{
    partial class main
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("인사코드 관리");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("부서코드 관리");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("직급코드 관리");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("직책코드 관리");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("인사기초정보", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("인사기본사항");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("가족사항");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("학력사항");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("상벌사항");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("경력사항");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("자격면허");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("외국어");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("인사기록 조회(통합)");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("인사기록관리", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("인사발령대장 관리");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("인사발령 등록");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("인사발령 조회");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("인사변동 관리", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("재직증명서");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("경력증명서");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("영문증명서");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("제증명서 발급대장 조회");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("제증명서 발급", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("부서별 인원현황");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("직급별 인원현황");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("입사인원 추이");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("퇴사인원 추이");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("현황 및 통계", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, -1);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "노드2";
            treeNode1.Text = "인사코드 관리";
            treeNode2.Name = "노드5";
            treeNode2.Text = "부서코드 관리";
            treeNode3.Name = "노드6";
            treeNode3.Text = "직급코드 관리";
            treeNode4.Name = "노드7";
            treeNode4.Text = "직책코드 관리";
            treeNode5.Name = "insa_info";
            treeNode5.Text = "인사기초정보";
            treeNode6.Name = "노드8";
            treeNode6.Text = "인사기본사항";
            treeNode7.Name = "노드9";
            treeNode7.Text = "가족사항";
            treeNode8.Name = "노드10";
            treeNode8.Text = "학력사항";
            treeNode9.Name = "노드11";
            treeNode9.Text = "상벌사항";
            treeNode10.Name = "노드12";
            treeNode10.Text = "경력사항";
            treeNode11.Name = "노드13";
            treeNode11.Text = "자격면허";
            treeNode12.Name = "노드14";
            treeNode12.Text = "외국어";
            treeNode13.Name = "노드15";
            treeNode13.Text = "인사기록 조회(통합)";
            treeNode14.Name = "2";
            treeNode14.Text = "인사기록관리";
            treeNode15.Name = "노드16";
            treeNode15.Text = "인사발령대장 관리";
            treeNode16.Name = "노드17";
            treeNode16.Text = "인사발령 등록";
            treeNode17.Name = "노드18";
            treeNode17.Text = "인사발령 조회";
            treeNode18.Name = "노드2";
            treeNode18.Text = "인사변동 관리";
            treeNode19.Name = "노드19";
            treeNode19.Text = "재직증명서";
            treeNode20.Name = "노드20";
            treeNode20.Text = "경력증명서";
            treeNode21.Name = "노드21";
            treeNode21.Text = "영문증명서";
            treeNode22.Name = "노드22";
            treeNode22.Text = "제증명서 발급대장 조회";
            treeNode23.Name = "노드4";
            treeNode23.Text = "제증명서 발급";
            treeNode24.Name = "노드23";
            treeNode24.Text = "부서별 인원현황";
            treeNode25.Name = "노드24";
            treeNode25.Text = "직급별 인원현황";
            treeNode26.Name = "노드25";
            treeNode26.Text = "입사인원 추이";
            treeNode27.Name = "노드26";
            treeNode27.Text = "퇴사인원 추이";
            treeNode28.Name = "노드5";
            treeNode28.Text = "현황 및 통계";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode14,
            treeNode18,
            treeNode23,
            treeNode28});
            this.treeView1.Size = new System.Drawing.Size(168, 719);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(167, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 719);
            this.panel1.TabIndex = 1;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1369, 719);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Name = "main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "인사관리시스템";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
    }
}