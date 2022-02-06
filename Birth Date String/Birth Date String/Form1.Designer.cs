
namespace Birth_Date_String
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dayOfWeekLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayOfMonthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayOfWeekLabel
            // 
            this.dayOfWeekLabel.AutoSize = true;
            this.dayOfWeekLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dayOfWeekLabel.Location = new System.Drawing.Point(76, 27);
            this.dayOfWeekLabel.Name = "dayOfWeekLabel";
            this.dayOfWeekLabel.Size = new System.Drawing.Size(169, 19);
            this.dayOfWeekLabel.TabIndex = 3;
            this.dayOfWeekLabel.Text = "Enter the day of the week:";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthLabel.Location = new System.Drawing.Point(54, 69);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(191, 19);
            this.monthLabel.TabIndex = 4;
            this.monthLabel.Text = "Enter the name of the month:";
            // 
            // dayOfMonthLabel
            // 
            this.dayOfMonthLabel.AutoSize = true;
            this.dayOfMonthLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dayOfMonthLabel.Location = new System.Drawing.Point(13, 109);
            this.dayOfMonthLabel.Name = "dayOfMonthLabel";
            this.dayOfMonthLabel.Size = new System.Drawing.Size(232, 19);
            this.dayOfMonthLabel.TabIndex = 5;
            this.dayOfMonthLabel.Text = "Enter the numeric day of the month:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearLabel.Location = new System.Drawing.Point(147, 151);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(98, 19);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Enter the year:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 280);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.dayOfMonthLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.dayOfWeekLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayOfWeekLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayOfMonthLabel;
        private System.Windows.Forms.Label yearLabel;
    }
}

