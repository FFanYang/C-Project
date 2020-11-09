namespace digitalClock
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
            this.components = new System.ComponentModel.Container();
            this.lblClockMins = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblWeekday = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblClockMins
            // 
            this.lblClockMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClockMins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClockMins.Location = new System.Drawing.Point(327, 9);
            this.lblClockMins.Name = "lblClockMins";
            this.lblClockMins.Size = new System.Drawing.Size(327, 120);
            this.lblClockMins.TabIndex = 0;
            this.lblClockMins.Text = "19:25";
            // 
            // lblS
            // 
            this.lblS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblS.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblS.Location = new System.Drawing.Point(389, 120);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(171, 122);
            this.lblS.TabIndex = 1;
            this.lblS.Text = "47";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(192, 222);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(594, 122);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Jan 03 2020";
            // 
            // lblWeekday
            // 
            this.lblWeekday.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWeekday.Location = new System.Drawing.Point(261, 335);
            this.lblWeekday.Name = "lblWeekday";
            this.lblWeekday.Size = new System.Drawing.Size(535, 122);
            this.lblWeekday.TabIndex = 3;
            this.lblWeekday.Text = "Monday";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(919, 483);
            this.Controls.Add(this.lblWeekday);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblClockMins);
            this.Name = "Form1";
            this.Text = "Digital Clock ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClockMins;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblWeekday;
        private System.Windows.Forms.Timer timer1;
    }
}

