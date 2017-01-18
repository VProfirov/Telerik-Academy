namespace BasicEvents
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CountriesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.AccessibleName = "";
            this.SubmitButton.Location = new System.Drawing.Point(53, 225);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(111, 39);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            this.SubmitButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SubmitButton_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Countries";
            // 
            // CountriesComboBox
            // 
            this.CountriesComboBox.FormattingEnabled = true;
            this.CountriesComboBox.IntegralHeight = false;
            this.CountriesComboBox.Location = new System.Drawing.Point(53, 180);
            this.CountriesComboBox.Name = "CountriesComboBox";
            this.CountriesComboBox.Size = new System.Drawing.Size(221, 21);
            this.CountriesComboBox.TabIndex = 2;
            this.CountriesComboBox.SelectedIndexChanged += new System.EventHandler(this.CountriesComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 454);
            this.Controls.Add(this.CountriesComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CountriesComboBox;
    }
}

