namespace RepetierHost.view
{
    partial class LeadScrewCalculatorDialog
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
            this.LSMotorAngle = new System.Windows.Forms.ComboBox();
            this.LSMicroSteps = new System.Windows.Forms.ComboBox();
            this.LSScrewPitch = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GearRatio0 = new System.Windows.Forms.TextBox();
            this.GearRatio1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LSOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LSMotorAngle
            // 
            this.LSMotorAngle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LSMotorAngle.FormattingEnabled = true;
            this.LSMotorAngle.Items.AddRange(new object[] {
            "1.8",
            "0.9",
            "7.5"});
            this.LSMotorAngle.Location = new System.Drawing.Point(151, 12);
            this.LSMotorAngle.Name = "LSMotorAngle";
            this.LSMotorAngle.Size = new System.Drawing.Size(121, 21);
            this.LSMotorAngle.TabIndex = 0;
            // 
            // LSMicroSteps
            // 
            this.LSMicroSteps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LSMicroSteps.FormattingEnabled = true;
            this.LSMicroSteps.Items.AddRange(new object[] {
            "1",
            "1/2",
            "1/4",
            "1/8",
            "1/16"});
            this.LSMicroSteps.Location = new System.Drawing.Point(151, 40);
            this.LSMicroSteps.Name = "LSMicroSteps";
            this.LSMicroSteps.Size = new System.Drawing.Size(121, 21);
            this.LSMicroSteps.TabIndex = 1;
            // 
            // LSScrewPitch
            // 
            this.LSScrewPitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LSScrewPitch.FormattingEnabled = true;
            this.LSScrewPitch.Items.AddRange(new object[] {
            "M8 ( 1.25mm per rotation )",
            "M6 ( 1mm per rotation )",
            "5/16 ( 1.41111mm per rotation )",
            "1/4\" - 16 ( 1.5875mm per rotation )"});
            this.LSScrewPitch.Location = new System.Drawing.Point(151, 68);
            this.LSScrewPitch.Name = "LSScrewPitch";
            this.LSScrewPitch.Size = new System.Drawing.Size(121, 21);
            this.LSScrewPitch.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GearRatio0
            // 
            this.GearRatio0.Location = new System.Drawing.Point(151, 96);
            this.GearRatio0.Name = "GearRatio0";
            this.GearRatio0.Size = new System.Drawing.Size(48, 20);
            this.GearRatio0.TabIndex = 5;
            this.GearRatio0.Text = "1";
            // 
            // GearRatio1
            // 
            this.GearRatio1.Location = new System.Drawing.Point(224, 95);
            this.GearRatio1.Name = "GearRatio1";
            this.GearRatio1.Size = new System.Drawing.Size(48, 20);
            this.GearRatio1.TabIndex = 6;
            this.GearRatio1.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Motor step angle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Driver microstepping";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Leadscrew pitch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gear ratio";
            // 
            // LSOutput
            // 
            this.LSOutput.Location = new System.Drawing.Point(15, 163);
            this.LSOutput.Name = "LSOutput";
            this.LSOutput.Size = new System.Drawing.Size(257, 20);
            this.LSOutput.TabIndex = 12;
            // 
            // LeadScrewCalculatorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 198);
            this.Controls.Add(this.LSOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GearRatio1);
            this.Controls.Add(this.GearRatio0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LSScrewPitch);
            this.Controls.Add(this.LSMicroSteps);
            this.Controls.Add(this.LSMotorAngle);
            this.Name = "LeadScrewCalculatorDialog";
            this.Text = "Lead Screw Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LSMotorAngle;
        private System.Windows.Forms.ComboBox LSMicroSteps;
        private System.Windows.Forms.ComboBox LSScrewPitch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox GearRatio0;
        private System.Windows.Forms.TextBox GearRatio1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LSOutput;
    }
}