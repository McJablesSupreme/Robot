namespace Robot
{
    partial class frmRobot
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
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnGoOne = new System.Windows.Forms.Button();
            this.btnGoTen = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCoordinates = new System.Windows.Forms.Label();
            this.btnResetPosition = new System.Windows.Forms.Button();
            this.lblRobot = new System.Windows.Forms.Label();
            this.gbxWindow = new System.Windows.Forms.GroupBox();
            this.lblBonk = new System.Windows.Forms.Label();
            this.trkBarSpeedControl = new System.Windows.Forms.TrackBar();
            this.lblMoveSpeed = new System.Windows.Forms.Label();
            this.lblCoin = new System.Windows.Forms.Label();
            this.gbxWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarSpeedControl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(88, 333);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(25, 23);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "&W";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(148, 333);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(25, 23);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = "&E";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(118, 353);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(25, 23);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "&S";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(118, 308);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(25, 23);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "&N";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnGoOne
            // 
            this.btnGoOne.Location = new System.Drawing.Point(22, 265);
            this.btnGoOne.Name = "btnGoOne";
            this.btnGoOne.Size = new System.Drawing.Size(46, 23);
            this.btnGoOne.TabIndex = 4;
            this.btnGoOne.Text = "Go &1";
            this.btnGoOne.UseVisualStyleBackColor = true;
            this.btnGoOne.Click += new System.EventHandler(this.btnGoOne_Click);
            // 
            // btnGoTen
            // 
            this.btnGoTen.Location = new System.Drawing.Point(196, 265);
            this.btnGoTen.Name = "btnGoTen";
            this.btnGoTen.Size = new System.Drawing.Size(46, 23);
            this.btnGoTen.TabIndex = 5;
            this.btnGoTen.Text = "&Go 10";
            this.btnGoTen.UseVisualStyleBackColor = true;
            this.btnGoTen.Click += new System.EventHandler(this.btnGoTen_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(175, 353);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.AutoSize = true;
            this.lblCoordinates.Location = new System.Drawing.Point(19, 5);
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(69, 13);
            this.lblCoordinates.TabIndex = 9;
            this.lblCoordinates.Text = "(X = ?, Y = ?)";
            // 
            // btnResetPosition
            // 
            this.btnResetPosition.Location = new System.Drawing.Point(6, 353);
            this.btnResetPosition.Name = "btnResetPosition";
            this.btnResetPosition.Size = new System.Drawing.Size(76, 23);
            this.btnResetPosition.TabIndex = 10;
            this.btnResetPosition.Text = "&Reset";
            this.btnResetPosition.UseVisualStyleBackColor = true;
            this.btnResetPosition.Click += new System.EventHandler(this.btnResetPosition_Click);
            // 
            // lblRobot
            // 
            this.lblRobot.AutoSize = true;
            this.lblRobot.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRobot.Location = new System.Drawing.Point(100, 105);
            this.lblRobot.Name = "lblRobot";
            this.lblRobot.Size = new System.Drawing.Size(21, 17);
            this.lblRobot.TabIndex = 7;
            this.lblRobot.Text = "↑";
            // 
            // gbxWindow
            // 
            this.gbxWindow.Controls.Add(this.lblRobot);
            this.gbxWindow.Controls.Add(this.lblCoin);
            this.gbxWindow.Location = new System.Drawing.Point(22, 16);
            this.gbxWindow.Name = "gbxWindow";
            this.gbxWindow.Size = new System.Drawing.Size(220, 225);
            this.gbxWindow.TabIndex = 8;
            this.gbxWindow.TabStop = false;
            // 
            // lblBonk
            // 
            this.lblBonk.AutoSize = true;
            this.lblBonk.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonk.Location = new System.Drawing.Point(104, -1);
            this.lblBonk.Name = "lblBonk";
            this.lblBonk.Size = new System.Drawing.Size(0, 14);
            this.lblBonk.TabIndex = 11;
            // 
            // trkBarSpeedControl
            // 
            this.trkBarSpeedControl.Location = new System.Drawing.Point(74, 248);
            this.trkBarSpeedControl.Minimum = 1;
            this.trkBarSpeedControl.Name = "trkBarSpeedControl";
            this.trkBarSpeedControl.Size = new System.Drawing.Size(116, 45);
            this.trkBarSpeedControl.TabIndex = 12;
            this.trkBarSpeedControl.Value = 1;
            this.trkBarSpeedControl.Scroll += new System.EventHandler(this.trkBarSpeedControl_Scroll);
            // 
            // lblMoveSpeed
            // 
            this.lblMoveSpeed.AutoSize = true;
            this.lblMoveSpeed.Location = new System.Drawing.Point(81, 280);
            this.lblMoveSpeed.Name = "lblMoveSpeed";
            this.lblMoveSpeed.Size = new System.Drawing.Size(77, 13);
            this.lblMoveSpeed.TabIndex = 13;
            this.lblMoveSpeed.Text = "Move Speed =";
            // 
            // lblCoin
            // 
            this.lblCoin.AutoSize = true;
            this.lblCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoin.Location = new System.Drawing.Point(103, 31);
            this.lblCoin.Name = "lblCoin";
            this.lblCoin.Size = new System.Drawing.Size(26, 18);
            this.lblCoin.TabIndex = 8;
            this.lblCoin.Text = "💰";
            // 
            // frmRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(263, 388);
            this.Controls.Add(this.lblMoveSpeed);
            this.Controls.Add(this.trkBarSpeedControl);
            this.Controls.Add(this.lblBonk);
            this.Controls.Add(this.btnResetPosition);
            this.Controls.Add(this.lblCoordinates);
            this.Controls.Add(this.gbxWindow);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoTen);
            this.Controls.Add(this.btnGoOne);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Name = "frmRobot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot";
            this.Load += new System.EventHandler(this.frmRobot_Load);
            this.gbxWindow.ResumeLayout(false);
            this.gbxWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarSpeedControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnGoOne;
        private System.Windows.Forms.Button btnGoTen;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCoordinates;
        private System.Windows.Forms.Button btnResetPosition;
        private System.Windows.Forms.Label lblRobot;
        private System.Windows.Forms.GroupBox gbxWindow;
        private System.Windows.Forms.Label lblBonk;
        private System.Windows.Forms.TrackBar trkBarSpeedControl;
        private System.Windows.Forms.Label lblMoveSpeed;
        private System.Windows.Forms.Label lblCoin;
    }
}

