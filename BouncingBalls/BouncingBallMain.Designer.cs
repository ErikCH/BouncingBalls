namespace BouncingBalls
{
    partial class BouncingBallMain
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
            this.mainPB = new System.Windows.Forms.PictureBox();
            this.addBall = new System.Windows.Forms.Button();
            this.resetBall = new System.Windows.Forms.Button();
            this.numOfBallsLbl = new System.Windows.Forms.Label();
            this.numOfBallsLblText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPB)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPB
            // 
            this.mainPB.BackColor = System.Drawing.Color.White;
            this.mainPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPB.Location = new System.Drawing.Point(12, 26);
            this.mainPB.Name = "mainPB";
            this.mainPB.Size = new System.Drawing.Size(416, 453);
            this.mainPB.TabIndex = 0;
            this.mainPB.TabStop = false;
            this.mainPB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPB_MouseClick);
            this.mainPB.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPB_Paint);
            // 
            // addBall
            // 
            this.addBall.Location = new System.Drawing.Point(472, 456);
            this.addBall.Name = "addBall";
            this.addBall.Size = new System.Drawing.Size(108, 23);
            this.addBall.TabIndex = 5;
            this.addBall.Text = "Add Ball";
            this.addBall.UseVisualStyleBackColor = true;
            this.addBall.Click += new System.EventHandler(this.addBall_Click);
            // 
            // resetBall
            // 
            this.resetBall.Location = new System.Drawing.Point(605, 456);
            this.resetBall.Name = "resetBall";
            this.resetBall.Size = new System.Drawing.Size(108, 23);
            this.resetBall.TabIndex = 6;
            this.resetBall.Text = "Reset Balls";
            this.resetBall.UseVisualStyleBackColor = true;
            this.resetBall.Click += new System.EventHandler(this.resetBall_Click);
            // 
            // numOfBallsLbl
            // 
            this.numOfBallsLbl.AutoSize = true;
            this.numOfBallsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfBallsLbl.Location = new System.Drawing.Point(651, 102);
            this.numOfBallsLbl.Name = "numOfBallsLbl";
            this.numOfBallsLbl.Size = new System.Drawing.Size(26, 29);
            this.numOfBallsLbl.TabIndex = 9;
            this.numOfBallsLbl.Text = "0";
            // 
            // numOfBallsLblText
            // 
            this.numOfBallsLblText.AutoSize = true;
            this.numOfBallsLblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfBallsLblText.Location = new System.Drawing.Point(449, 102);
            this.numOfBallsLblText.Name = "numOfBallsLblText";
            this.numOfBallsLblText.Size = new System.Drawing.Size(196, 29);
            this.numOfBallsLblText.TabIndex = 8;
            this.numOfBallsLblText.Text = "Number Of Balls:";
            // 
            // BouncingBallMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 553);
            this.Controls.Add(this.numOfBallsLbl);
            this.Controls.Add(this.numOfBallsLblText);
            this.Controls.Add(this.resetBall);
            this.Controls.Add(this.addBall);
            this.Controls.Add(this.mainPB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BouncingBallMain";
            this.Text = "Bouncing Ball";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BouncingBallMain_MouseClick);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BouncingBallMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mainPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPB;
        private System.Windows.Forms.Button addBall;
        private System.Windows.Forms.Button resetBall;
        private System.Windows.Forms.Label numOfBallsLbl;
        private System.Windows.Forms.Label numOfBallsLblText;

    }
}

