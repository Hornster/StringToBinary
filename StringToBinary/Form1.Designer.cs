namespace StringToBinary
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
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConvertTriggerButton = new System.Windows.Forms.Button();
            this.binaryToStringSet = new System.Windows.Forms.RadioButton();
            this.StringToBinarySet = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ErrorDisplayLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(50, 48);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(264, 161);
            this.InputTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(50, 235);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(264, 22);
            this.OutputTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output";
            // 
            // ConvertTriggerButton
            // 
            this.ConvertTriggerButton.Location = new System.Drawing.Point(428, 117);
            this.ConvertTriggerButton.Name = "ConvertTriggerButton";
            this.ConvertTriggerButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertTriggerButton.TabIndex = 4;
            this.ConvertTriggerButton.Text = "Convert";
            this.ConvertTriggerButton.UseVisualStyleBackColor = true;
            this.ConvertTriggerButton.Click += new System.EventHandler(this.ConvertButtonClick_Click);
            // 
            // binaryToStringSet
            // 
            this.binaryToStringSet.AutoSize = true;
            this.binaryToStringSet.Location = new System.Drawing.Point(6, 21);
            this.binaryToStringSet.Name = "binaryToStringSet";
            this.binaryToStringSet.Size = new System.Drawing.Size(87, 21);
            this.binaryToStringSet.TabIndex = 5;
            this.binaryToStringSet.Text = "To String";
            this.binaryToStringSet.UseVisualStyleBackColor = true;
            this.binaryToStringSet.CheckedChanged += new System.EventHandler(this.binaryToStringSet_CheckedChanged);
            // 
            // StringToBinarySet
            // 
            this.StringToBinarySet.AutoSize = true;
            this.StringToBinarySet.Checked = true;
            this.StringToBinarySet.Location = new System.Drawing.Point(6, 48);
            this.StringToBinarySet.Name = "StringToBinarySet";
            this.StringToBinarySet.Size = new System.Drawing.Size(90, 21);
            this.StringToBinarySet.TabIndex = 6;
            this.StringToBinarySet.TabStop = true;
            this.StringToBinarySet.Text = "To Binary";
            this.StringToBinarySet.UseVisualStyleBackColor = true;
            this.StringToBinarySet.CheckedChanged += new System.EventHandler(this.StringToBinarySet_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.binaryToStringSet);
            this.groupBox1.Controls.Add(this.StringToBinarySet);
            this.groupBox1.Location = new System.Drawing.Point(333, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 82);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion type";
            // 
            // ErrorDisplayLabel
            // 
            this.ErrorDisplayLabel.AutoSize = true;
            this.ErrorDisplayLabel.Location = new System.Drawing.Point(50, 264);
            this.ErrorDisplayLabel.Name = "ErrorDisplayLabel";
            this.ErrorDisplayLabel.Size = new System.Drawing.Size(0, 17);
            this.ErrorDisplayLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 391);
            this.Controls.Add(this.ErrorDisplayLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConvertTriggerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConvertTriggerButton;
        private System.Windows.Forms.RadioButton binaryToStringSet;
        private System.Windows.Forms.RadioButton StringToBinarySet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ErrorDisplayLabel;
    }
}

