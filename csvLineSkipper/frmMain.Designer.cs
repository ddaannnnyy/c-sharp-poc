namespace csvLineSkipper
{
    partial class frmMain
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblFileLocation = new System.Windows.Forms.Label();
            this.nudArrayValueOne = new System.Windows.Forms.NumericUpDown();
            this.nudArrayValueTwo = new System.Windows.Forms.NumericUpDown();
            this.nudCounter = new System.Windows.Forms.NumericUpDown();
            this.chkCounter = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudArrayValueOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArrayValueTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(507, 12);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(281, 426);
            this.txtOutput.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(99, 254);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(120, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblFileLocation
            // 
            this.lblFileLocation.AutoSize = true;
            this.lblFileLocation.Location = new System.Drawing.Point(12, 112);
            this.lblFileLocation.Name = "lblFileLocation";
            this.lblFileLocation.Size = new System.Drawing.Size(29, 13);
            this.lblFileLocation.TabIndex = 2;
            this.lblFileLocation.Text = "URL";
            this.lblFileLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudArrayValueOne
            // 
            this.nudArrayValueOne.Location = new System.Drawing.Point(99, 176);
            this.nudArrayValueOne.Name = "nudArrayValueOne";
            this.nudArrayValueOne.Size = new System.Drawing.Size(120, 20);
            this.nudArrayValueOne.TabIndex = 3;
            // 
            // nudArrayValueTwo
            // 
            this.nudArrayValueTwo.Location = new System.Drawing.Point(99, 202);
            this.nudArrayValueTwo.Name = "nudArrayValueTwo";
            this.nudArrayValueTwo.Size = new System.Drawing.Size(120, 20);
            this.nudArrayValueTwo.TabIndex = 4;
            // 
            // nudCounter
            // 
            this.nudCounter.Location = new System.Drawing.Point(99, 228);
            this.nudCounter.Name = "nudCounter";
            this.nudCounter.ReadOnly = true;
            this.nudCounter.Size = new System.Drawing.Size(120, 20);
            this.nudCounter.TabIndex = 5;
            // 
            // chkCounter
            // 
            this.chkCounter.AutoSize = true;
            this.chkCounter.Location = new System.Drawing.Point(225, 231);
            this.chkCounter.Name = "chkCounter";
            this.chkCounter.Size = new System.Drawing.Size(91, 17);
            this.chkCounter.TabIndex = 6;
            this.chkCounter.Text = "Use Counter?";
            this.chkCounter.UseVisualStyleBackColor = true;
            this.chkCounter.CheckedChanged += new System.EventHandler(this.chkCounter_CheckedChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 178);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 13);
            label1.TabIndex = 7;
            label1.Text = "Array Point One";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 204);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 13);
            label2.TabIndex = 8;
            label2.Text = "Array Point Two";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.chkCounter);
            this.Controls.Add(this.nudCounter);
            this.Controls.Add(this.nudArrayValueTwo);
            this.Controls.Add(this.nudArrayValueOne);
            this.Controls.Add(this.lblFileLocation);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtOutput);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudArrayValueOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArrayValueTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblFileLocation;
        private System.Windows.Forms.NumericUpDown nudArrayValueOne;
        private System.Windows.Forms.NumericUpDown nudArrayValueTwo;
        private System.Windows.Forms.NumericUpDown nudCounter;
        private System.Windows.Forms.CheckBox chkCounter;
    }
}

