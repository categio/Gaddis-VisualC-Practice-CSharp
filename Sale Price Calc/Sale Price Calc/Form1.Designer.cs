
namespace Sale_Price_Calc
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.outputDescLabel = new System.Windows.Forms.Label();
            this.totOutputLabel = new System.Windows.Forms.Label();
            this.fivePictureBox = new System.Windows.Forms.PictureBox();
            this.tenCentPictureBox = new System.Windows.Forms.PictureBox();
            this.twenty5CentPictureBox = new System.Windows.Forms.PictureBox();
            this.fiftyCentPictureBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fivePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenCentPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twenty5CentPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyCentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.BackColor = System.Drawing.Color.White;
            this.instructionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructionLabel.Location = new System.Drawing.Point(80, 12);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(108, 19);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "CLICK THE COINS";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescLabel
            // 
            this.outputDescLabel.AutoSize = true;
            this.outputDescLabel.BackColor = System.Drawing.Color.White;
            this.outputDescLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputDescLabel.Location = new System.Drawing.Point(199, 93);
            this.outputDescLabel.Name = "outputDescLabel";
            this.outputDescLabel.Size = new System.Drawing.Size(45, 19);
            this.outputDescLabel.TabIndex = 1;
            this.outputDescLabel.Text = "TOTAL";
            this.outputDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totOutputLabel
            // 
            this.totOutputLabel.BackColor = System.Drawing.Color.White;
            this.totOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totOutputLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.totOutputLabel.Location = new System.Drawing.Point(187, 124);
            this.totOutputLabel.Name = "totOutputLabel";
            this.totOutputLabel.Size = new System.Drawing.Size(68, 19);
            this.totOutputLabel.TabIndex = 2;
            this.totOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fivePictureBox
            // 
            this.fivePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fivePictureBox.Image = global::Sale_Price_Calc.Properties.Resources._5_cent;
            this.fivePictureBox.Location = new System.Drawing.Point(7, 46);
            this.fivePictureBox.Name = "fivePictureBox";
            this.fivePictureBox.Size = new System.Drawing.Size(78, 79);
            this.fivePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fivePictureBox.TabIndex = 3;
            this.fivePictureBox.TabStop = false;
            this.fivePictureBox.Click += new System.EventHandler(this.fivePictureBox_Click);
            // 
            // tenCentPictureBox
            // 
            this.tenCentPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tenCentPictureBox.Image = global::Sale_Price_Calc.Properties.Resources._10_cent;
            this.tenCentPictureBox.Location = new System.Drawing.Point(91, 46);
            this.tenCentPictureBox.Name = "tenCentPictureBox";
            this.tenCentPictureBox.Size = new System.Drawing.Size(78, 79);
            this.tenCentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tenCentPictureBox.TabIndex = 4;
            this.tenCentPictureBox.TabStop = false;
            this.tenCentPictureBox.Click += new System.EventHandler(this.tenCentPictureBox_Click);
            // 
            // twenty5CentPictureBox
            // 
            this.twenty5CentPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.twenty5CentPictureBox.Image = global::Sale_Price_Calc.Properties.Resources._25_cent;
            this.twenty5CentPictureBox.Location = new System.Drawing.Point(7, 131);
            this.twenty5CentPictureBox.Name = "twenty5CentPictureBox";
            this.twenty5CentPictureBox.Size = new System.Drawing.Size(78, 79);
            this.twenty5CentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twenty5CentPictureBox.TabIndex = 5;
            this.twenty5CentPictureBox.TabStop = false;
            this.twenty5CentPictureBox.Click += new System.EventHandler(this.twenty5CentPictureBox_Click);
            // 
            // fiftyCentPictureBox
            // 
            this.fiftyCentPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fiftyCentPictureBox.Image = global::Sale_Price_Calc.Properties.Resources._50_cent;
            this.fiftyCentPictureBox.Location = new System.Drawing.Point(91, 131);
            this.fiftyCentPictureBox.Name = "fiftyCentPictureBox";
            this.fiftyCentPictureBox.Size = new System.Drawing.Size(78, 79);
            this.fiftyCentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fiftyCentPictureBox.TabIndex = 6;
            this.fiftyCentPictureBox.TabStop = false;
            this.fiftyCentPictureBox.Click += new System.EventHandler(this.fiftyCentPictureBox_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.BorderSize = 3;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Location = new System.Drawing.Point(36, 216);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(194, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&XIT PROGRAM";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearButton.FlatAppearance.BorderSize = 3;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Location = new System.Drawing.Point(189, 156);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(65, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 247);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.fiftyCentPictureBox);
            this.Controls.Add(this.twenty5CentPictureBox);
            this.Controls.Add(this.tenCentPictureBox);
            this.Controls.Add(this.fivePictureBox);
            this.Controls.Add(this.totOutputLabel);
            this.Controls.Add(this.outputDescLabel);
            this.Controls.Add(this.instructionLabel);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Change Counter";
            ((System.ComponentModel.ISupportInitialize)(this.fivePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenCentPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twenty5CentPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyCentPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label outputDescLabel;
        private System.Windows.Forms.Label totOutputLabel;
        private System.Windows.Forms.PictureBox fivePictureBox;
        private System.Windows.Forms.PictureBox tenCentPictureBox;
        private System.Windows.Forms.PictureBox twenty5CentPictureBox;
        private System.Windows.Forms.PictureBox fiftyCentPictureBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

