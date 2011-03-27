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
            this.dyLabel = new System.Windows.Forms.Label();
            this.dxLabel = new System.Windows.Forms.Label();
            this.dxLabelA = new System.Windows.Forms.Label();
            this.dyLabelA = new System.Windows.Forms.Label();
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
            this.mainPB.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPB_Paint);
            // 
            // dyLabel
            // 
            this.dyLabel.AutoSize = true;
            this.dyLabel.Location = new System.Drawing.Point(90, 506);
            this.dyLabel.Name = "dyLabel";
            this.dyLabel.Size = new System.Drawing.Size(21, 13);
            this.dyLabel.TabIndex = 1;
            this.dyLabel.Text = "dy:";
            // 
            // dxLabel
            // 
            this.dxLabel.AutoSize = true;
            this.dxLabel.Location = new System.Drawing.Point(27, 506);
            this.dxLabel.Name = "dxLabel";
            this.dxLabel.Size = new System.Drawing.Size(21, 13);
            this.dxLabel.TabIndex = 2;
            this.dxLabel.Text = "dx:";
            // 
            // dxLabelA
            // 
            this.dxLabelA.AutoSize = true;
            this.dxLabelA.Location = new System.Drawing.Point(45, 506);
            this.dxLabelA.Name = "dxLabelA";
            this.dxLabelA.Size = new System.Drawing.Size(35, 13);
            this.dxLabelA.TabIndex = 3;
            this.dxLabelA.Text = "label1";
            // 
            // dyLabelA
            // 
            this.dyLabelA.AutoSize = true;
            this.dyLabelA.Location = new System.Drawing.Point(118, 506);
            this.dyLabelA.Name = "dyLabelA";
            this.dyLabelA.Size = new System.Drawing.Size(35, 13);
            this.dyLabelA.TabIndex = 4;
            this.dyLabelA.Text = "label2";
            // 
            // BouncingBallMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 553);
            this.Controls.Add(this.dyLabelA);
            this.Controls.Add(this.dxLabelA);
            this.Controls.Add(this.dxLabel);
            this.Controls.Add(this.dyLabel);
            this.Controls.Add(this.mainPB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BouncingBallMain";
            this.Text = "Bouncing Ball";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BouncingBallMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mainPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPB;
        private System.Windows.Forms.Label dyLabel;
        private System.Windows.Forms.Label dxLabel;
        private System.Windows.Forms.Label dxLabelA;
        private System.Windows.Forms.Label dyLabelA;

    }
}

