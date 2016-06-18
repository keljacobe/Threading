namespace WindowsFormsApplication3
{
    partial class Form1
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
            this.btnThread1 = new System.Windows.Forms.Button();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.btnThread3 = new System.Windows.Forms.Button();
            this.btnThread2 = new System.Windows.Forms.Button();
            this.btnThread4 = new System.Windows.Forms.Button();
            this.pbxRed = new System.Windows.Forms.PictureBox();
            this.pbxGreen = new System.Windows.Forms.PictureBox();
            this.pbxBlue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThread1
            // 
            this.btnThread1.Location = new System.Drawing.Point(31, 28);
            this.btnThread1.Name = "btnThread1";
            this.btnThread1.Size = new System.Drawing.Size(100, 23);
            this.btnThread1.TabIndex = 0;
            this.btnThread1.Text = "Thread1";
            this.btnThread1.UseVisualStyleBackColor = true;
            this.btnThread1.Click += new System.EventHandler(this.btnThread1_Click);
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(31, 57);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(100, 20);
            this.tbx1.TabIndex = 4;
            // 
            // tbx3
            // 
            this.tbx3.Location = new System.Drawing.Point(243, 57);
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(100, 20);
            this.tbx3.TabIndex = 5;
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(137, 57);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(100, 20);
            this.tbx2.TabIndex = 6;
            // 
            // btnThread3
            // 
            this.btnThread3.Location = new System.Drawing.Point(243, 28);
            this.btnThread3.Name = "btnThread3";
            this.btnThread3.Size = new System.Drawing.Size(100, 23);
            this.btnThread3.TabIndex = 7;
            this.btnThread3.Text = "Thread3";
            this.btnThread3.UseVisualStyleBackColor = true;
            this.btnThread3.Click += new System.EventHandler(this.btnThread3_Click);
            // 
            // btnThread2
            // 
            this.btnThread2.Location = new System.Drawing.Point(137, 28);
            this.btnThread2.Name = "btnThread2";
            this.btnThread2.Size = new System.Drawing.Size(100, 23);
            this.btnThread2.TabIndex = 8;
            this.btnThread2.Text = "Thread2";
            this.btnThread2.UseVisualStyleBackColor = true;
            this.btnThread2.Click += new System.EventHandler(this.btnThread2_Click);
            // 
            // btnThread4
            // 
            this.btnThread4.Location = new System.Drawing.Point(349, 28);
            this.btnThread4.Name = "btnThread4";
            this.btnThread4.Size = new System.Drawing.Size(100, 23);
            this.btnThread4.TabIndex = 9;
            this.btnThread4.Text = "Thread4";
            this.btnThread4.UseVisualStyleBackColor = true;
            this.btnThread4.Click += new System.EventHandler(this.btnThread4_Click);
            // 
            // pbxRed
            // 
            this.pbxRed.BackColor = System.Drawing.Color.Red;
            this.pbxRed.Location = new System.Drawing.Point(31, 83);
            this.pbxRed.Name = "pbxRed";
            this.pbxRed.Size = new System.Drawing.Size(100, 50);
            this.pbxRed.TabIndex = 10;
            this.pbxRed.TabStop = false;
            // 
            // pbxGreen
            // 
            this.pbxGreen.BackColor = System.Drawing.Color.Lime;
            this.pbxGreen.Location = new System.Drawing.Point(31, 195);
            this.pbxGreen.Name = "pbxGreen";
            this.pbxGreen.Size = new System.Drawing.Size(100, 50);
            this.pbxGreen.TabIndex = 11;
            this.pbxGreen.TabStop = false;
            // 
            // pbxBlue
            // 
            this.pbxBlue.BackColor = System.Drawing.Color.Blue;
            this.pbxBlue.Location = new System.Drawing.Point(31, 139);
            this.pbxBlue.Name = "pbxBlue";
            this.pbxBlue.Size = new System.Drawing.Size(100, 50);
            this.pbxBlue.TabIndex = 12;
            this.pbxBlue.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 402);
            this.Controls.Add(this.pbxBlue);
            this.Controls.Add(this.pbxGreen);
            this.Controls.Add(this.pbxRed);
            this.Controls.Add(this.btnThread4);
            this.Controls.Add(this.btnThread2);
            this.Controls.Add(this.btnThread3);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.tbx3);
            this.Controls.Add(this.tbx1);
            this.Controls.Add(this.btnThread1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThread1;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.TextBox tbx3;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.Button btnThread3;
        private System.Windows.Forms.Button btnThread2;
        private System.Windows.Forms.Button btnThread4;
        private System.Windows.Forms.PictureBox pbxRed;
        private System.Windows.Forms.PictureBox pbxGreen;
        private System.Windows.Forms.PictureBox pbxBlue;
    }
}

