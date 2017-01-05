namespace CreateWorld
{
    partial class CameraEditor
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
            this.CameraType = new System.Windows.Forms.CheckBox();
            this.groupPerspective = new System.Windows.Forms.GroupBox();
            this.FPPLabel = new System.Windows.Forms.Label();
            this.StringFPP = new System.Windows.Forms.TextBox();
            this.NPPLabel = new System.Windows.Forms.Label();
            this.StringNPP = new System.Windows.Forms.TextBox();
            this.ARLabel = new System.Windows.Forms.Label();
            this.StringAR = new System.Windows.Forms.TextBox();
            this.FOVLabel = new System.Windows.Forms.Label();
            this.StringFOV = new System.Windows.Forms.TextBox();
            this.groupOrthographic = new System.Windows.Forms.GroupBox();
            this.FPOLabel = new System.Windows.Forms.Label();
            this.TopLabel = new System.Windows.Forms.Label();
            this.BotomLabel = new System.Windows.Forms.Label();
            this.NPOLabel = new System.Windows.Forms.Label();
            this.RightLabel = new System.Windows.Forms.Label();
            this.LeftLabel = new System.Windows.Forms.Label();
            this.StringFPO = new System.Windows.Forms.TextBox();
            this.StringTop = new System.Windows.Forms.TextBox();
            this.StringBottom = new System.Windows.Forms.TextBox();
            this.StringNPO = new System.Windows.Forms.TextBox();
            this.StringRight = new System.Windows.Forms.TextBox();
            this.StringLeft = new System.Windows.Forms.TextBox();
            this.groupUpdate = new System.Windows.Forms.GroupBox();
            this.UpdateTypes = new System.Windows.Forms.ComboBox();
            this.groupIPos = new System.Windows.Forms.GroupBox();
            this.ZLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.StringZ = new System.Windows.Forms.TextBox();
            this.StringY = new System.Windows.Forms.TextBox();
            this.StringX = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelRZ = new System.Windows.Forms.Label();
            this.RYLabel = new System.Windows.Forms.Label();
            this.RXLabel = new System.Windows.Forms.Label();
            this.StringRZ = new System.Windows.Forms.TextBox();
            this.StringRY = new System.Windows.Forms.TextBox();
            this.StringRX = new System.Windows.Forms.TextBox();
            this.groupSave = new System.Windows.Forms.GroupBox();
            this.StringSave = new System.Windows.Forms.TextBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.groupPerspective.SuspendLayout();
            this.groupOrthographic.SuspendLayout();
            this.groupUpdate.SuspendLayout();
            this.groupIPos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // CameraType
            // 
            this.CameraType.AutoSize = true;
            this.CameraType.Location = new System.Drawing.Point(12, 12);
            this.CameraType.Name = "CameraType";
            this.CameraType.Size = new System.Drawing.Size(99, 17);
            this.CameraType.TabIndex = 0;
            this.CameraType.Text = "Is Perspective?";
            this.CameraType.UseVisualStyleBackColor = true;
            this.CameraType.CheckedChanged += new System.EventHandler(this.CameraType_CheckedChanged);
            // 
            // groupPerspective
            // 
            this.groupPerspective.Controls.Add(this.FPPLabel);
            this.groupPerspective.Controls.Add(this.StringFPP);
            this.groupPerspective.Controls.Add(this.NPPLabel);
            this.groupPerspective.Controls.Add(this.StringNPP);
            this.groupPerspective.Controls.Add(this.ARLabel);
            this.groupPerspective.Controls.Add(this.StringAR);
            this.groupPerspective.Controls.Add(this.FOVLabel);
            this.groupPerspective.Controls.Add(this.StringFOV);
            this.groupPerspective.Location = new System.Drawing.Point(12, 35);
            this.groupPerspective.Name = "groupPerspective";
            this.groupPerspective.Size = new System.Drawing.Size(230, 72);
            this.groupPerspective.TabIndex = 1;
            this.groupPerspective.TabStop = false;
            this.groupPerspective.Text = "Perspective";
            // 
            // FPPLabel
            // 
            this.FPPLabel.AutoSize = true;
            this.FPPLabel.Location = new System.Drawing.Point(156, 48);
            this.FPPLabel.Name = "FPPLabel";
            this.FPPLabel.Size = new System.Drawing.Size(52, 13);
            this.FPPLabel.TabIndex = 7;
            this.FPPLabel.Text = "Far Plane";
            // 
            // StringFPP
            // 
            this.StringFPP.Location = new System.Drawing.Point(121, 45);
            this.StringFPP.Name = "StringFPP";
            this.StringFPP.Size = new System.Drawing.Size(29, 20);
            this.StringFPP.TabIndex = 6;
            this.StringFPP.TextChanged += new System.EventHandler(this.StringFPP_TextChanged);
            // 
            // NPPLabel
            // 
            this.NPPLabel.AutoSize = true;
            this.NPPLabel.Location = new System.Drawing.Point(156, 22);
            this.NPPLabel.Name = "NPPLabel";
            this.NPPLabel.Size = new System.Drawing.Size(60, 13);
            this.NPPLabel.TabIndex = 5;
            this.NPPLabel.Text = "Near Plane";
            // 
            // StringNPP
            // 
            this.StringNPP.Location = new System.Drawing.Point(121, 19);
            this.StringNPP.Name = "StringNPP";
            this.StringNPP.Size = new System.Drawing.Size(29, 20);
            this.StringNPP.TabIndex = 4;
            this.StringNPP.TextChanged += new System.EventHandler(this.StringNPP_TextChanged);
            // 
            // ARLabel
            // 
            this.ARLabel.AutoSize = true;
            this.ARLabel.Location = new System.Drawing.Point(41, 48);
            this.ARLabel.Name = "ARLabel";
            this.ARLabel.Size = new System.Drawing.Size(68, 13);
            this.ARLabel.TabIndex = 3;
            this.ARLabel.Text = "Aspect Ratio";
            // 
            // StringAR
            // 
            this.StringAR.Location = new System.Drawing.Point(6, 45);
            this.StringAR.Name = "StringAR";
            this.StringAR.Size = new System.Drawing.Size(29, 20);
            this.StringAR.TabIndex = 2;
            this.StringAR.TextChanged += new System.EventHandler(this.StringAR_TextChanged);
            // 
            // FOVLabel
            // 
            this.FOVLabel.AutoSize = true;
            this.FOVLabel.Location = new System.Drawing.Point(41, 22);
            this.FOVLabel.Name = "FOVLabel";
            this.FOVLabel.Size = new System.Drawing.Size(67, 13);
            this.FOVLabel.TabIndex = 1;
            this.FOVLabel.Text = "Field of View";
            // 
            // StringFOV
            // 
            this.StringFOV.Location = new System.Drawing.Point(6, 19);
            this.StringFOV.Name = "StringFOV";
            this.StringFOV.Size = new System.Drawing.Size(29, 20);
            this.StringFOV.TabIndex = 0;
            this.StringFOV.TextChanged += new System.EventHandler(this.StringFOV_TextChanged);
            // 
            // groupOrthographic
            // 
            this.groupOrthographic.Controls.Add(this.FPOLabel);
            this.groupOrthographic.Controls.Add(this.TopLabel);
            this.groupOrthographic.Controls.Add(this.BotomLabel);
            this.groupOrthographic.Controls.Add(this.NPOLabel);
            this.groupOrthographic.Controls.Add(this.RightLabel);
            this.groupOrthographic.Controls.Add(this.LeftLabel);
            this.groupOrthographic.Controls.Add(this.StringFPO);
            this.groupOrthographic.Controls.Add(this.StringTop);
            this.groupOrthographic.Controls.Add(this.StringBottom);
            this.groupOrthographic.Controls.Add(this.StringNPO);
            this.groupOrthographic.Controls.Add(this.StringRight);
            this.groupOrthographic.Controls.Add(this.StringLeft);
            this.groupOrthographic.Location = new System.Drawing.Point(12, 114);
            this.groupOrthographic.Name = "groupOrthographic";
            this.groupOrthographic.Size = new System.Drawing.Size(230, 99);
            this.groupOrthographic.TabIndex = 2;
            this.groupOrthographic.TabStop = false;
            this.groupOrthographic.Text = "Orthographic";
            // 
            // FPOLabel
            // 
            this.FPOLabel.AutoSize = true;
            this.FPOLabel.Location = new System.Drawing.Point(156, 74);
            this.FPOLabel.Name = "FPOLabel";
            this.FPOLabel.Size = new System.Drawing.Size(52, 13);
            this.FPOLabel.TabIndex = 11;
            this.FPOLabel.Text = "Far Plane";
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Location = new System.Drawing.Point(156, 48);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(26, 13);
            this.TopLabel.TabIndex = 10;
            this.TopLabel.Text = "Top";
            // 
            // BotomLabel
            // 
            this.BotomLabel.AutoSize = true;
            this.BotomLabel.Location = new System.Drawing.Point(156, 22);
            this.BotomLabel.Name = "BotomLabel";
            this.BotomLabel.Size = new System.Drawing.Size(40, 13);
            this.BotomLabel.TabIndex = 9;
            this.BotomLabel.Text = "Bottom";
            // 
            // NPOLabel
            // 
            this.NPOLabel.AutoSize = true;
            this.NPOLabel.Location = new System.Drawing.Point(41, 74);
            this.NPOLabel.Name = "NPOLabel";
            this.NPOLabel.Size = new System.Drawing.Size(60, 13);
            this.NPOLabel.TabIndex = 8;
            this.NPOLabel.Text = "Near Plane";
            // 
            // RightLabel
            // 
            this.RightLabel.AutoSize = true;
            this.RightLabel.Location = new System.Drawing.Point(41, 48);
            this.RightLabel.Name = "RightLabel";
            this.RightLabel.Size = new System.Drawing.Size(32, 13);
            this.RightLabel.TabIndex = 7;
            this.RightLabel.Text = "Right";
            // 
            // LeftLabel
            // 
            this.LeftLabel.AutoSize = true;
            this.LeftLabel.Location = new System.Drawing.Point(41, 22);
            this.LeftLabel.Name = "LeftLabel";
            this.LeftLabel.Size = new System.Drawing.Size(25, 13);
            this.LeftLabel.TabIndex = 6;
            this.LeftLabel.Text = "Left";
            // 
            // StringFPO
            // 
            this.StringFPO.Location = new System.Drawing.Point(121, 71);
            this.StringFPO.Name = "StringFPO";
            this.StringFPO.Size = new System.Drawing.Size(29, 20);
            this.StringFPO.TabIndex = 5;
            this.StringFPO.TextChanged += new System.EventHandler(this.StringFPO_TextChanged);
            // 
            // StringTop
            // 
            this.StringTop.Location = new System.Drawing.Point(121, 45);
            this.StringTop.Name = "StringTop";
            this.StringTop.Size = new System.Drawing.Size(29, 20);
            this.StringTop.TabIndex = 4;
            this.StringTop.TextChanged += new System.EventHandler(this.StringTop_TextChanged);
            // 
            // StringBottom
            // 
            this.StringBottom.Location = new System.Drawing.Point(121, 19);
            this.StringBottom.Name = "StringBottom";
            this.StringBottom.Size = new System.Drawing.Size(29, 20);
            this.StringBottom.TabIndex = 3;
            this.StringBottom.TextChanged += new System.EventHandler(this.StringBottom_TextChanged);
            // 
            // StringNPO
            // 
            this.StringNPO.Location = new System.Drawing.Point(6, 71);
            this.StringNPO.Name = "StringNPO";
            this.StringNPO.Size = new System.Drawing.Size(29, 20);
            this.StringNPO.TabIndex = 2;
            this.StringNPO.TextChanged += new System.EventHandler(this.StringNPO_TextChanged);
            // 
            // StringRight
            // 
            this.StringRight.Location = new System.Drawing.Point(6, 45);
            this.StringRight.Name = "StringRight";
            this.StringRight.Size = new System.Drawing.Size(29, 20);
            this.StringRight.TabIndex = 1;
            this.StringRight.TextChanged += new System.EventHandler(this.StringRight_TextChanged);
            // 
            // StringLeft
            // 
            this.StringLeft.Location = new System.Drawing.Point(6, 19);
            this.StringLeft.Name = "StringLeft";
            this.StringLeft.Size = new System.Drawing.Size(29, 20);
            this.StringLeft.TabIndex = 0;
            this.StringLeft.TextChanged += new System.EventHandler(this.StringLeft_TextChanged);
            // 
            // groupUpdate
            // 
            this.groupUpdate.Controls.Add(this.UpdateTypes);
            this.groupUpdate.Location = new System.Drawing.Point(12, 219);
            this.groupUpdate.Name = "groupUpdate";
            this.groupUpdate.Size = new System.Drawing.Size(230, 48);
            this.groupUpdate.TabIndex = 3;
            this.groupUpdate.TabStop = false;
            this.groupUpdate.Text = "Update Type";
            // 
            // UpdateTypes
            // 
            this.UpdateTypes.FormattingEnabled = true;
            this.UpdateTypes.Location = new System.Drawing.Point(6, 19);
            this.UpdateTypes.Name = "UpdateTypes";
            this.UpdateTypes.Size = new System.Drawing.Size(218, 21);
            this.UpdateTypes.TabIndex = 0;
            // 
            // groupIPos
            // 
            this.groupIPos.Controls.Add(this.ZLabel);
            this.groupIPos.Controls.Add(this.YLabel);
            this.groupIPos.Controls.Add(this.XLabel);
            this.groupIPos.Controls.Add(this.StringZ);
            this.groupIPos.Controls.Add(this.StringY);
            this.groupIPos.Controls.Add(this.StringX);
            this.groupIPos.Location = new System.Drawing.Point(12, 273);
            this.groupIPos.Name = "groupIPos";
            this.groupIPos.Size = new System.Drawing.Size(230, 46);
            this.groupIPos.TabIndex = 4;
            this.groupIPos.TabStop = false;
            this.groupIPos.Text = "Initial Position";
            // 
            // ZLabel
            // 
            this.ZLabel.AutoSize = true;
            this.ZLabel.Location = new System.Drawing.Point(172, 22);
            this.ZLabel.Name = "ZLabel";
            this.ZLabel.Size = new System.Drawing.Size(14, 13);
            this.ZLabel.TabIndex = 5;
            this.ZLabel.Text = "Z";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(91, 22);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(14, 13);
            this.YLabel.TabIndex = 6;
            this.YLabel.Text = "Y";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(10, 22);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(14, 13);
            this.XLabel.TabIndex = 5;
            this.XLabel.Text = "X";
            // 
            // StringZ
            // 
            this.StringZ.Location = new System.Drawing.Point(192, 19);
            this.StringZ.Name = "StringZ";
            this.StringZ.Size = new System.Drawing.Size(29, 20);
            this.StringZ.TabIndex = 2;
            this.StringZ.TextChanged += new System.EventHandler(this.StringZ_TextChanged);
            // 
            // StringY
            // 
            this.StringY.Location = new System.Drawing.Point(111, 19);
            this.StringY.Name = "StringY";
            this.StringY.Size = new System.Drawing.Size(29, 20);
            this.StringY.TabIndex = 1;
            this.StringY.TextChanged += new System.EventHandler(this.StringY_TextChanged);
            // 
            // StringX
            // 
            this.StringX.Location = new System.Drawing.Point(30, 19);
            this.StringX.Name = "StringX";
            this.StringX.Size = new System.Drawing.Size(29, 20);
            this.StringX.TabIndex = 0;
            this.StringX.TextChanged += new System.EventHandler(this.StringX_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelRZ);
            this.groupBox1.Controls.Add(this.RYLabel);
            this.groupBox1.Controls.Add(this.RXLabel);
            this.groupBox1.Controls.Add(this.StringRZ);
            this.groupBox1.Controls.Add(this.StringRY);
            this.groupBox1.Controls.Add(this.StringRX);
            this.groupBox1.Location = new System.Drawing.Point(12, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 45);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initial Reference";
            // 
            // LabelRZ
            // 
            this.LabelRZ.AutoSize = true;
            this.LabelRZ.Location = new System.Drawing.Point(164, 22);
            this.LabelRZ.Name = "LabelRZ";
            this.LabelRZ.Size = new System.Drawing.Size(22, 13);
            this.LabelRZ.TabIndex = 6;
            this.LabelRZ.Text = "RZ";
            // 
            // RYLabel
            // 
            this.RYLabel.AutoSize = true;
            this.RYLabel.Location = new System.Drawing.Point(83, 22);
            this.RYLabel.Name = "RYLabel";
            this.RYLabel.Size = new System.Drawing.Size(22, 13);
            this.RYLabel.TabIndex = 7;
            this.RYLabel.Text = "RY";
            // 
            // RXLabel
            // 
            this.RXLabel.AutoSize = true;
            this.RXLabel.Location = new System.Drawing.Point(6, 22);
            this.RXLabel.Name = "RXLabel";
            this.RXLabel.Size = new System.Drawing.Size(22, 13);
            this.RXLabel.TabIndex = 6;
            this.RXLabel.Text = "RX";
            // 
            // StringRZ
            // 
            this.StringRZ.Location = new System.Drawing.Point(192, 19);
            this.StringRZ.Name = "StringRZ";
            this.StringRZ.Size = new System.Drawing.Size(29, 20);
            this.StringRZ.TabIndex = 2;
            this.StringRZ.TextChanged += new System.EventHandler(this.StringRZ_TextChanged);
            // 
            // StringRY
            // 
            this.StringRY.Location = new System.Drawing.Point(111, 19);
            this.StringRY.Name = "StringRY";
            this.StringRY.Size = new System.Drawing.Size(29, 20);
            this.StringRY.TabIndex = 1;
            this.StringRY.TextChanged += new System.EventHandler(this.StringRY_TextChanged);
            // 
            // StringRX
            // 
            this.StringRX.Location = new System.Drawing.Point(34, 19);
            this.StringRX.Name = "StringRX";
            this.StringRX.Size = new System.Drawing.Size(29, 20);
            this.StringRX.TabIndex = 0;
            this.StringRX.TextChanged += new System.EventHandler(this.StringRX_TextChanged);
            // 
            // groupSave
            // 
            this.groupSave.Controls.Add(this.StringSave);
            this.groupSave.Location = new System.Drawing.Point(12, 376);
            this.groupSave.Name = "groupSave";
            this.groupSave.Size = new System.Drawing.Size(230, 47);
            this.groupSave.TabIndex = 6;
            this.groupSave.TabStop = false;
            this.groupSave.Text = "Path Save Data";
            // 
            // StringSave
            // 
            this.StringSave.Location = new System.Drawing.Point(6, 19);
            this.StringSave.Name = "StringSave";
            this.StringSave.Size = new System.Drawing.Size(218, 20);
            this.StringSave.TabIndex = 0;
            this.StringSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StringSave_MouseClick);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(133, 434);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(109, 23);
            this.DoneButton.TabIndex = 7;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // CameraEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 469);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.groupSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupIPos);
            this.Controls.Add(this.groupUpdate);
            this.Controls.Add(this.groupOrthographic);
            this.Controls.Add(this.groupPerspective);
            this.Controls.Add(this.CameraType);
            this.Name = "CameraEditor";
            this.Text = "Camera Editor";
            this.groupPerspective.ResumeLayout(false);
            this.groupPerspective.PerformLayout();
            this.groupOrthographic.ResumeLayout(false);
            this.groupOrthographic.PerformLayout();
            this.groupUpdate.ResumeLayout(false);
            this.groupIPos.ResumeLayout(false);
            this.groupIPos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupSave.ResumeLayout(false);
            this.groupSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CameraType;
        private System.Windows.Forms.GroupBox groupPerspective;
        private System.Windows.Forms.Label FPPLabel;
        private System.Windows.Forms.TextBox StringFPP;
        private System.Windows.Forms.Label NPPLabel;
        private System.Windows.Forms.TextBox StringNPP;
        private System.Windows.Forms.Label ARLabel;
        private System.Windows.Forms.TextBox StringAR;
        private System.Windows.Forms.Label FOVLabel;
        private System.Windows.Forms.TextBox StringFOV;
        private System.Windows.Forms.GroupBox groupOrthographic;
        private System.Windows.Forms.TextBox StringFPO;
        private System.Windows.Forms.TextBox StringTop;
        private System.Windows.Forms.TextBox StringBottom;
        private System.Windows.Forms.TextBox StringNPO;
        private System.Windows.Forms.TextBox StringRight;
        private System.Windows.Forms.TextBox StringLeft;
        private System.Windows.Forms.Label FPOLabel;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label BotomLabel;
        private System.Windows.Forms.Label NPOLabel;
        private System.Windows.Forms.Label RightLabel;
        private System.Windows.Forms.Label LeftLabel;
        private System.Windows.Forms.GroupBox groupUpdate;
        private System.Windows.Forms.ComboBox UpdateTypes;
        private System.Windows.Forms.GroupBox groupIPos;
        private System.Windows.Forms.Label ZLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.TextBox StringZ;
        private System.Windows.Forms.TextBox StringY;
        private System.Windows.Forms.TextBox StringX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelRZ;
        private System.Windows.Forms.Label RYLabel;
        private System.Windows.Forms.Label RXLabel;
        private System.Windows.Forms.TextBox StringRZ;
        private System.Windows.Forms.TextBox StringRY;
        private System.Windows.Forms.TextBox StringRX;
        private System.Windows.Forms.GroupBox groupSave;
        private System.Windows.Forms.TextBox StringSave;
        private System.Windows.Forms.Button DoneButton;
    }
}