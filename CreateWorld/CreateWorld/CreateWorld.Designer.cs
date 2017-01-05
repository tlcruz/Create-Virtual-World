namespace CreateWorld
{
    partial class CreateWorld
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Root");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VRExample = new System.Windows.Forms.PictureBox();
            this.ObjectList = new System.Windows.Forms.TreeView();
            this.AddObject = new System.Windows.Forms.Button();
            this.RemoveObject = new System.Windows.Forms.Button();
            this.SelectCamera = new System.Windows.Forms.Button();
            this.ExportWorld = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VRExample)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // VRExample
            // 
            this.VRExample.Location = new System.Drawing.Point(204, 27);
            this.VRExample.Name = "VRExample";
            this.VRExample.Size = new System.Drawing.Size(422, 297);
            this.VRExample.TabIndex = 1;
            this.VRExample.TabStop = false;
            // 
            // ObjectList
            // 
            this.ObjectList.Location = new System.Drawing.Point(12, 27);
            this.ObjectList.Name = "ObjectList";
            treeNode1.Checked = true;
            treeNode1.Name = "Root";
            treeNode1.Text = "Root";
            this.ObjectList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.ObjectList.Size = new System.Drawing.Size(186, 155);
            this.ObjectList.TabIndex = 2;
            this.ObjectList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ObjectList_NodeMouseDoubleClick);
            // 
            // AddObject
            // 
            this.AddObject.Location = new System.Drawing.Point(12, 188);
            this.AddObject.Name = "AddObject";
            this.AddObject.Size = new System.Drawing.Size(89, 23);
            this.AddObject.TabIndex = 3;
            this.AddObject.Text = "Add";
            this.AddObject.UseVisualStyleBackColor = true;
            this.AddObject.Click += new System.EventHandler(this.AddObject_Click);
            // 
            // RemoveObject
            // 
            this.RemoveObject.Location = new System.Drawing.Point(107, 188);
            this.RemoveObject.Name = "RemoveObject";
            this.RemoveObject.Size = new System.Drawing.Size(91, 23);
            this.RemoveObject.TabIndex = 4;
            this.RemoveObject.Text = "Remove";
            this.RemoveObject.UseVisualStyleBackColor = true;
            this.RemoveObject.Click += new System.EventHandler(this.RemoveObject_Click);
            // 
            // SelectCamera
            // 
            this.SelectCamera.Location = new System.Drawing.Point(12, 217);
            this.SelectCamera.Name = "SelectCamera";
            this.SelectCamera.Size = new System.Drawing.Size(186, 26);
            this.SelectCamera.TabIndex = 5;
            this.SelectCamera.Text = "Select Camera";
            this.SelectCamera.UseVisualStyleBackColor = true;
            this.SelectCamera.Click += new System.EventHandler(this.SelectCamera_Click);
            // 
            // ExportWorld
            // 
            this.ExportWorld.Location = new System.Drawing.Point(12, 275);
            this.ExportWorld.Name = "ExportWorld";
            this.ExportWorld.Size = new System.Drawing.Size(186, 49);
            this.ExportWorld.TabIndex = 6;
            this.ExportWorld.Text = "Export World";
            this.ExportWorld.UseVisualStyleBackColor = true;
            this.ExportWorld.Click += new System.EventHandler(this.ExportWorld_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 7;
            // 
            // CreateWorld
            // 
            this.ClientSize = new System.Drawing.Size(638, 336);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ExportWorld);
            this.Controls.Add(this.SelectCamera);
            this.Controls.Add(this.RemoveObject);
            this.Controls.Add(this.AddObject);
            this.Controls.Add(this.ObjectList);
            this.Controls.Add(this.VRExample);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateWorld";
            this.Text = "Create World";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VRExample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.PictureBox VRExample;
        public System.Windows.Forms.TreeView ObjectList;
        private System.Windows.Forms.Button AddObject;
        private System.Windows.Forms.Button RemoveObject;
        private System.Windows.Forms.Button SelectCamera;
        private System.Windows.Forms.Button ExportWorld;
        private System.Windows.Forms.TextBox textBox1;
    }
}

