
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
            this.dayOfWeekTextbox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayOfMonthTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.showDateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayOfWeekLabel
            // 
            this.dayOfWeekLabel.AutoSize = true;
            this.dayOfWeekLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dayOfWeekLabel.Location = new System.Drawing.Point(87, 19);
            this.dayOfWeekLabel.Name = "dayOfWeekLabel";
            this.dayOfWeekLabel.Size = new System.Drawing.Size(169, 17);
            this.dayOfWeekLabel.TabIndex = 3;
            this.dayOfWeekLabel.Text = "Enter the day of the week:";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monthLabel.Location = new System.Drawing.Point(62, 66);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(190, 17);
            this.monthLabel.TabIndex = 4;
            this.monthLabel.Text = "Enter the name of the month:";
            // 
            // dayOfMonthLabel
            // 
            this.dayOfMonthLabel.AutoSize = true;
            this.dayOfMonthLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dayOfMonthLabel.Location = new System.Drawing.Point(15, 112);
            this.dayOfMonthLabel.Name = "dayOfMonthLabel";
            this.dayOfMonthLabel.Size = new System.Drawing.Size(231, 17);
            this.dayOfMonthLabel.TabIndex = 5;
            this.dayOfMonthLabel.Text = "Enter the numeric day of the month:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yearLabel.Location = new System.Drawing.Point(154, 158);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(98, 17);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Enter the year:";
            // 
            // dayOfWeekTextbox
            // 
            this.dayOfWeekTextbox.Location = new System.Drawing.Point(299, 19);
            this.dayOfWeekTextbox.Name = "dayOfWeekTextbox";
            this.dayOfWeekTextbox.Size = new System.Drawing.Size(114, 25);
            this.dayOfWeekTextbox.TabIndex = 7;
            this.dayOfWeekTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(299, 62);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(114, 25);
            this.monthTextBox.TabIndex = 8;
            this.monthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dayOfMonthTextBox
            // 
            this.dayOfMonthTextBox.Location = new System.Drawing.Point(299, 110);
            this.dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            this.dayOfMonthTextBox.Size = new System.Drawing.Size(114, 25);
            this.dayOfMonthTextBox.TabIndex = 9;
            this.dayOfMonthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(299, 158);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(114, 25);
            this.yearTextBox.TabIndex = 10;
            this.yearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.BackColor = System.Drawing.Color.White;
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutputLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateOutputLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateOutputLabel.Location = new System.Drawing.Point(15, 217);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(398, 26);
            this.dateOutputLabel.TabIndex = 11;
            this.dateOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showDateButton
            // 
            this.showDateButton.BackColor = System.Drawing.Color.Azure;
            this.showDateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.showDateButton.FlatAppearance.BorderSize = 5;
            this.showDateButton.Location = new System.Drawing.Point(15, 261);
            this.showDateButton.Name = "showDateButton";
            this.showDateButton.Size = new System.Drawing.Size(118, 32);
            this.showDateButton.TabIndex = 12;
            this.showDateButton.Text = "Show Date";
            this.showDateButton.UseVisualStyleBackColor = false;
            this.showDateButton.Click += new System.EventHandler(this.showDateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Azure;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearButton.FlatAppearance.BorderSize = 5;
            this.clearButton.Location = new System.Drawing.Point(154, 261);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(118, 32);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Azure;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.BorderSize = 5;
            this.exitButton.Location = new System.Drawing.Point(292, 261);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(118, 32);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(431, 311);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showDateButton);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayOfMonthTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.dayOfWeekTextbox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.dayOfMonthLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.dayOfWeekLabel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Birth Date String Generator";
            this.TransparencyKey = System.Drawing.SystemColors.ControlText;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayOfWeekLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayOfMonthLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox dayOfWeekTextbox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayOfMonthTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.Button showDateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

