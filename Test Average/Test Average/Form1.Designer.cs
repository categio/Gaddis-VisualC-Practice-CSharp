
namespace Test_Average
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
            this.test1PromptLabel = new System.Windows.Forms.Label();
            this.test2PromptLabel = new System.Windows.Forms.Label();
            this.test3PromptLabel = new System.Windows.Forms.Label();
            this.outputDescriptLabel = new System.Windows.Forms.Label();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.averageLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test1PromptLabel
            // 
            this.test1PromptLabel.AutoSize = true;
            this.test1PromptLabel.BackColor = System.Drawing.Color.Snow;
            this.test1PromptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.test1PromptLabel.Location = new System.Drawing.Point(27, 24);
            this.test1PromptLabel.Name = "test1PromptLabel";
            this.test1PromptLabel.Size = new System.Drawing.Size(94, 19);
            this.test1PromptLabel.TabIndex = 0;
            this.test1PromptLabel.Text = "TEST SCORE 1 :";
            // 
            // test2PromptLabel
            // 
            this.test2PromptLabel.AutoSize = true;
            this.test2PromptLabel.BackColor = System.Drawing.Color.Snow;
            this.test2PromptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.test2PromptLabel.Location = new System.Drawing.Point(27, 56);
            this.test2PromptLabel.Name = "test2PromptLabel";
            this.test2PromptLabel.Size = new System.Drawing.Size(94, 19);
            this.test2PromptLabel.TabIndex = 1;
            this.test2PromptLabel.Text = "TEST SCORE 2 :";
            // 
            // test3PromptLabel
            // 
            this.test3PromptLabel.AutoSize = true;
            this.test3PromptLabel.BackColor = System.Drawing.Color.Snow;
            this.test3PromptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.test3PromptLabel.Location = new System.Drawing.Point(27, 88);
            this.test3PromptLabel.Name = "test3PromptLabel";
            this.test3PromptLabel.Size = new System.Drawing.Size(94, 19);
            this.test3PromptLabel.TabIndex = 2;
            this.test3PromptLabel.Text = "TEST SCORE 3 :";
            // 
            // outputDescriptLabel
            // 
            this.outputDescriptLabel.AutoSize = true;
            this.outputDescriptLabel.BackColor = System.Drawing.Color.Snow;
            this.outputDescriptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputDescriptLabel.Location = new System.Drawing.Point(44, 141);
            this.outputDescriptLabel.Name = "outputDescriptLabel";
            this.outputDescriptLabel.Size = new System.Drawing.Size(139, 19);
            this.outputDescriptLabel.TabIndex = 3;
            this.outputDescriptLabel.Text = "AVERAGE TEST SCORE :";
            // 
            // test1TextBox
            // 
            this.test1TextBox.BackColor = System.Drawing.Color.Snow;
            this.test1TextBox.ForeColor = System.Drawing.Color.Firebrick;
            this.test1TextBox.Location = new System.Drawing.Point(161, 21);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(100, 22);
            this.test1TextBox.TabIndex = 4;
            this.test1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // test2TextBox
            // 
            this.test2TextBox.BackColor = System.Drawing.Color.Snow;
            this.test2TextBox.ForeColor = System.Drawing.Color.Firebrick;
            this.test2TextBox.Location = new System.Drawing.Point(161, 53);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(100, 22);
            this.test2TextBox.TabIndex = 5;
            this.test2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // test3TextBox
            // 
            this.test3TextBox.BackColor = System.Drawing.Color.Snow;
            this.test3TextBox.ForeColor = System.Drawing.Color.Firebrick;
            this.test3TextBox.Location = new System.Drawing.Point(161, 85);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(100, 22);
            this.test3TextBox.TabIndex = 6;
            this.test3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // averageLabel
            // 
            this.averageLabel.BackColor = System.Drawing.Color.Snow;
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(196, 141);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(103, 19);
            this.averageLabel.TabIndex = 8;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Gainsboro;
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.calculateButton.FlatAppearance.BorderSize = 3;
            this.calculateButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateButton.Location = new System.Drawing.Point(18, 203);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(94, 56);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "CALCULATE AVERAGE";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Gainsboro;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearButton.FlatAppearance.BorderSize = 3;
            this.clearButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Location = new System.Drawing.Point(118, 203);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 56);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "CLEAR DATA";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Gainsboro;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.BorderSize = 3;
            this.exitButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Location = new System.Drawing.Point(218, 203);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 56);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(330, 286);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.test3TextBox);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test1TextBox);
            this.Controls.Add(this.outputDescriptLabel);
            this.Controls.Add(this.test3PromptLabel);
            this.Controls.Add(this.test2PromptLabel);
            this.Controls.Add(this.test1PromptLabel);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Firebrick;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Test Average Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label test1PromptLabel;
        private System.Windows.Forms.Label test2PromptLabel;
        private System.Windows.Forms.Label test3PromptLabel;
        private System.Windows.Forms.Label outputDescriptLabel;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

