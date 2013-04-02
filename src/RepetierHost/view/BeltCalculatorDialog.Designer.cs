namespace RepetierHost.view
{
    partial class BeltCalculatorDialog
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
            this.MotorStepAngleInput = new System.Windows.Forms.ComboBox();
            this.MotorMicrosteppingInput = new System.Windows.Forms.ComboBox();
            this.BeltPitchInput = new System.Windows.Forms.ComboBox();
            this.ToothCountInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StepsPerMMOutput = new System.Windows.Forms.TextBox();
            this.BeltCalculatorCalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MotorStepAngleInput
            // 
            this.MotorStepAngleInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MotorStepAngleInput.FormattingEnabled = true;
            this.MotorStepAngleInput.Items.AddRange(new object[] {
            "1.8",
            "0.9",
            "7.5"});
            this.MotorStepAngleInput.Location = new System.Drawing.Point(151, 12);
            this.MotorStepAngleInput.Name = "MotorStepAngleInput";
            this.MotorStepAngleInput.Size = new System.Drawing.Size(121, 21);
            this.MotorStepAngleInput.TabIndex = 0;
            // 
            // MotorMicrosteppingInput
            // 
            this.MotorMicrosteppingInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MotorMicrosteppingInput.FormattingEnabled = true;
            this.MotorMicrosteppingInput.Items.AddRange(new object[] {
            "1",
            "1/2",
            "1/4",
            "1/8",
            "1/16"});
            this.MotorMicrosteppingInput.Location = new System.Drawing.Point(151, 40);
            this.MotorMicrosteppingInput.Name = "MotorMicrosteppingInput";
            this.MotorMicrosteppingInput.Size = new System.Drawing.Size(121, 21);
            this.MotorMicrosteppingInput.TabIndex = 1;
            // 
            // BeltPitchInput
            // 
            this.BeltPitchInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BeltPitchInput.FormattingEnabled = true;
            this.BeltPitchInput.Items.AddRange(new object[] {
            "2mm ( GT2 Belt )",
            "2.03mm ( MXL Belt )",
            "2.5mm ( T2.5 )",
            "3mm ( GT2, HTD )",
            "5mm ( T5, GT2, HTD )",
            "5.08mm ( 0.2\" XL Belt )"});
            this.BeltPitchInput.Location = new System.Drawing.Point(151, 68);
            this.BeltPitchInput.Name = "BeltPitchInput";
            this.BeltPitchInput.Size = new System.Drawing.Size(121, 21);
            this.BeltPitchInput.TabIndex = 2;
            // 
            // ToothCountInput
            // 
            this.ToothCountInput.Location = new System.Drawing.Point(151, 96);
            this.ToothCountInput.Name = "ToothCountInput";
            this.ToothCountInput.Size = new System.Drawing.Size(121, 20);
            this.ToothCountInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Motor step angle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Driver Microstepping";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Belt Pitch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tooth Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Steps per mm value ";
            // 
            // StepsPerMMOutput
            // 
            this.StepsPerMMOutput.Location = new System.Drawing.Point(151, 151);
            this.StepsPerMMOutput.Name = "StepsPerMMOutput";
            this.StepsPerMMOutput.Size = new System.Drawing.Size(121, 20);
            this.StepsPerMMOutput.TabIndex = 9;
            // 
            // BeltCalculatorCalculateButton
            // 
            this.BeltCalculatorCalculateButton.Location = new System.Drawing.Point(15, 122);
            this.BeltCalculatorCalculateButton.Name = "BeltCalculatorCalculateButton";
            this.BeltCalculatorCalculateButton.Size = new System.Drawing.Size(257, 23);
            this.BeltCalculatorCalculateButton.TabIndex = 10;
            this.BeltCalculatorCalculateButton.Text = "Calculate";
            this.BeltCalculatorCalculateButton.UseVisualStyleBackColor = true;
            this.BeltCalculatorCalculateButton.Click += new System.EventHandler(this.BeltCalculatorCalculateButton_Click);
            // 
            // BeltCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.BeltCalculatorCalculateButton);
            this.Controls.Add(this.StepsPerMMOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToothCountInput);
            this.Controls.Add(this.BeltPitchInput);
            this.Controls.Add(this.MotorMicrosteppingInput);
            this.Controls.Add(this.MotorStepAngleInput);
            this.Name = "BeltCalculator";
            this.Text = "Belt Calculator";
            this.Load += new System.EventHandler(this.BeltCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MotorStepAngleInput;
        private System.Windows.Forms.ComboBox MotorMicrosteppingInput;
        private System.Windows.Forms.ComboBox BeltPitchInput;
        private System.Windows.Forms.TextBox ToothCountInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StepsPerMMOutput;
        private System.Windows.Forms.Button BeltCalculatorCalculateButton;
    }
}