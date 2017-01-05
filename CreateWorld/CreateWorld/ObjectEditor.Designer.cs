namespace CreateWorld
{
    partial class ObjectEditor
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.ZLabel = new System.Windows.Forms.Label();
            this.RXLabel = new System.Windows.Forms.Label();
            this.RYLabel = new System.Windows.Forms.Label();
            this.RZLabel = new System.Windows.Forms.Label();
            this.StringX = new System.Windows.Forms.TextBox();
            this.StringY = new System.Windows.Forms.TextBox();
            this.StringZ = new System.Windows.Forms.TextBox();
            this.StringRX = new System.Windows.Forms.TextBox();
            this.StringRY = new System.Windows.Forms.TextBox();
            this.StringRZ = new System.Windows.Forms.TextBox();
            this.groupName = new System.Windows.Forms.GroupBox();
            this.groupPosition = new System.Windows.Forms.GroupBox();
            this.groupModel = new System.Windows.Forms.GroupBox();
            this.StringModel = new System.Windows.Forms.TextBox();
            this.RemoveModelButton = new System.Windows.Forms.Button();
            this.AddModelButton = new System.Windows.Forms.Button();
            this.groupUpdate = new System.Windows.Forms.GroupBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.UpdateTypes = new System.Windows.Forms.ComboBox();
            this.groupName.SuspendLayout();
            this.groupPosition.SuspendLayout();
            this.groupModel.SuspendLayout();
            this.groupUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(6, 15);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(193, 20);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(23, 82);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(14, 13);
            this.XLabel.TabIndex = 3;
            this.XLabel.Text = "X";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(74, 23);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(14, 13);
            this.YLabel.TabIndex = 4;
            this.YLabel.Text = "Y";
            // 
            // ZLabel
            // 
            this.ZLabel.AutoSize = true;
            this.ZLabel.Location = new System.Drawing.Point(138, 23);
            this.ZLabel.Name = "ZLabel";
            this.ZLabel.Size = new System.Drawing.Size(14, 13);
            this.ZLabel.TabIndex = 5;
            this.ZLabel.Text = "Z";
            // 
            // RXLabel
            // 
            this.RXLabel.AutoSize = true;
            this.RXLabel.Location = new System.Drawing.Point(23, 106);
            this.RXLabel.Name = "RXLabel";
            this.RXLabel.Size = new System.Drawing.Size(22, 13);
            this.RXLabel.TabIndex = 6;
            this.RXLabel.Text = "RX";
            // 
            // RYLabel
            // 
            this.RYLabel.AutoSize = true;
            this.RYLabel.Location = new System.Drawing.Point(74, 47);
            this.RYLabel.Name = "RYLabel";
            this.RYLabel.Size = new System.Drawing.Size(22, 13);
            this.RYLabel.TabIndex = 7;
            this.RYLabel.Text = "RY";
            // 
            // RZLabel
            // 
            this.RZLabel.AutoSize = true;
            this.RZLabel.Location = new System.Drawing.Point(138, 47);
            this.RZLabel.Name = "RZLabel";
            this.RZLabel.Size = new System.Drawing.Size(22, 13);
            this.RZLabel.TabIndex = 8;
            this.RZLabel.Text = "RZ";
            // 
            // StringX
            // 
            this.StringX.Location = new System.Drawing.Point(31, 20);
            this.StringX.Name = "StringX";
            this.StringX.Size = new System.Drawing.Size(25, 20);
            this.StringX.TabIndex = 9;
            this.StringX.TextChanged += new System.EventHandler(this.StringX_TextChanged);
            // 
            // StringY
            // 
            this.StringY.Location = new System.Drawing.Point(94, 20);
            this.StringY.Name = "StringY";
            this.StringY.Size = new System.Drawing.Size(25, 20);
            this.StringY.TabIndex = 10;
            this.StringY.TextChanged += new System.EventHandler(this.StringY_TextChanged);
            // 
            // StringZ
            // 
            this.StringZ.Location = new System.Drawing.Point(158, 20);
            this.StringZ.Name = "StringZ";
            this.StringZ.Size = new System.Drawing.Size(25, 20);
            this.StringZ.TabIndex = 11;
            this.StringZ.TextChanged += new System.EventHandler(this.StringZ_TextChanged);
            // 
            // StringRX
            // 
            this.StringRX.Location = new System.Drawing.Point(39, 44);
            this.StringRX.Name = "StringRX";
            this.StringRX.Size = new System.Drawing.Size(24, 20);
            this.StringRX.TabIndex = 12;
            this.StringRX.TextChanged += new System.EventHandler(this.StringRX_TextChanged);
            // 
            // StringRY
            // 
            this.StringRY.Location = new System.Drawing.Point(102, 44);
            this.StringRY.Name = "StringRY";
            this.StringRY.Size = new System.Drawing.Size(25, 20);
            this.StringRY.TabIndex = 13;
            this.StringRY.TextChanged += new System.EventHandler(this.StringRY_TextChanged);
            // 
            // StringRZ
            // 
            this.StringRZ.Location = new System.Drawing.Point(178, 103);
            this.StringRZ.Name = "StringRZ";
            this.StringRZ.Size = new System.Drawing.Size(25, 20);
            this.StringRZ.TabIndex = 14;
            this.StringRZ.TextChanged += new System.EventHandler(this.StringRZ_TextChanged);
            // 
            // groupName
            // 
            this.groupName.Controls.Add(this.NameBox);
            this.groupName.Location = new System.Drawing.Point(12, 12);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(205, 41);
            this.groupName.TabIndex = 15;
            this.groupName.TabStop = false;
            this.groupName.Text = "Name";
            // 
            // groupPosition
            // 
            this.groupPosition.Controls.Add(this.StringRY);
            this.groupPosition.Controls.Add(this.StringRX);
            this.groupPosition.Controls.Add(this.StringZ);
            this.groupPosition.Controls.Add(this.StringY);
            this.groupPosition.Controls.Add(this.StringX);
            this.groupPosition.Controls.Add(this.RZLabel);
            this.groupPosition.Controls.Add(this.RYLabel);
            this.groupPosition.Controls.Add(this.ZLabel);
            this.groupPosition.Controls.Add(this.YLabel);
            this.groupPosition.Location = new System.Drawing.Point(12, 59);
            this.groupPosition.Name = "groupPosition";
            this.groupPosition.Size = new System.Drawing.Size(205, 71);
            this.groupPosition.TabIndex = 16;
            this.groupPosition.TabStop = false;
            this.groupPosition.Text = "Position";
            // 
            // groupModel
            // 
            this.groupModel.Controls.Add(this.StringModel);
            this.groupModel.Controls.Add(this.RemoveModelButton);
            this.groupModel.Controls.Add(this.AddModelButton);
            this.groupModel.Location = new System.Drawing.Point(12, 136);
            this.groupModel.Name = "groupModel";
            this.groupModel.Size = new System.Drawing.Size(205, 77);
            this.groupModel.TabIndex = 17;
            this.groupModel.TabStop = false;
            this.groupModel.Text = "Model";
            // 
            // StringModel
            // 
            this.StringModel.Location = new System.Drawing.Point(6, 48);
            this.StringModel.Name = "StringModel";
            this.StringModel.Size = new System.Drawing.Size(193, 20);
            this.StringModel.TabIndex = 2;
            // 
            // RemoveModelButton
            // 
            this.RemoveModelButton.Location = new System.Drawing.Point(102, 19);
            this.RemoveModelButton.Name = "RemoveModelButton";
            this.RemoveModelButton.Size = new System.Drawing.Size(97, 23);
            this.RemoveModelButton.TabIndex = 1;
            this.RemoveModelButton.Text = "Remove Model";
            this.RemoveModelButton.UseVisualStyleBackColor = true;
            this.RemoveModelButton.Click += new System.EventHandler(this.RemoveModelButton_Click);
            // 
            // AddModelButton
            // 
            this.AddModelButton.Location = new System.Drawing.Point(6, 19);
            this.AddModelButton.Name = "AddModelButton";
            this.AddModelButton.Size = new System.Drawing.Size(95, 23);
            this.AddModelButton.TabIndex = 0;
            this.AddModelButton.Text = "Add Model";
            this.AddModelButton.UseVisualStyleBackColor = true;
            this.AddModelButton.Click += new System.EventHandler(this.AddModelButton_Click);
            // 
            // groupUpdate
            // 
            this.groupUpdate.Controls.Add(this.UpdateTypes);
            this.groupUpdate.Location = new System.Drawing.Point(12, 219);
            this.groupUpdate.Name = "groupUpdate";
            this.groupUpdate.Size = new System.Drawing.Size(206, 47);
            this.groupUpdate.TabIndex = 18;
            this.groupUpdate.TabStop = false;
            this.groupUpdate.Text = "Dynamics";
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(114, 276);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(104, 23);
            this.DoneButton.TabIndex = 19;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // UpdateTypes
            // 
            this.UpdateTypes.FormattingEnabled = true;
            this.UpdateTypes.Location = new System.Drawing.Point(6, 19);
            this.UpdateTypes.Name = "UpdateTypes";
            this.UpdateTypes.Size = new System.Drawing.Size(193, 21);
            this.UpdateTypes.TabIndex = 0;
            // 
            // ObjectEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 305);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.groupUpdate);
            this.Controls.Add(this.groupModel);
            this.Controls.Add(this.StringRZ);
            this.Controls.Add(this.RXLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.groupName);
            this.Controls.Add(this.groupPosition);
            this.Name = "ObjectEditor";
            this.Text = "ObjectEditor";
            this.groupName.ResumeLayout(false);
            this.groupName.PerformLayout();
            this.groupPosition.ResumeLayout(false);
            this.groupPosition.PerformLayout();
            this.groupModel.ResumeLayout(false);
            this.groupModel.PerformLayout();
            this.groupUpdate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label ZLabel;
        private System.Windows.Forms.Label RXLabel;
        private System.Windows.Forms.Label RYLabel;
        private System.Windows.Forms.Label RZLabel;
        private System.Windows.Forms.TextBox StringX;
        private System.Windows.Forms.TextBox StringY;
        private System.Windows.Forms.TextBox StringZ;
        private System.Windows.Forms.TextBox StringRX;
        private System.Windows.Forms.TextBox StringRY;
        private System.Windows.Forms.TextBox StringRZ;
        private System.Windows.Forms.GroupBox groupName;
        private System.Windows.Forms.GroupBox groupPosition;
        private System.Windows.Forms.GroupBox groupModel;
        private System.Windows.Forms.TextBox StringModel;
        private System.Windows.Forms.Button RemoveModelButton;
        private System.Windows.Forms.Button AddModelButton;
        private System.Windows.Forms.GroupBox groupUpdate;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.ComboBox UpdateTypes;
    }
}