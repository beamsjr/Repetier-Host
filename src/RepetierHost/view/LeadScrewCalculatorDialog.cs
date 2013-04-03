using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RepetierHost.model;

namespace RepetierHost.view
{
    public partial class LeadScrewCalculatorDialog : Form
    {
        public LeadScrewCalculatorDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedStepAngle = LSMotorAngle.SelectedIndex;
            var selectedMicrostepValue = LSMicroSteps.SelectedIndex;
            var selectedScrewPitch = LSScrewPitch.SelectedIndex;

            int GearRatio0Val;

            if (!int.TryParse(GearRatio0.Text, out GearRatio0Val))
            {
                LSOutput.Text ="Tooth Count must be int";
                return;
            }

            int GearRatio1Val;
            if (!int.TryParse(GearRatio0.Text, out GearRatio1Val))
            {
                LSOutput.Text = "Tooth Count must be int";
                return;
            }

            double GearRatio = (GearRatio0Val/GearRatio1Val);

            var stepAngles = new List<double>{1.8,0.9,7.5};
            var stepAngle = stepAngles[selectedStepAngle];

            var microStepValues = new List<double>() {1, 0.5, 0.25, 0.125, 0.0625};
            var microStep = microStepValues[selectedMicrostepValue];

            var screwPitchValues = new List<double>() { 1.25, 1, 1.41111, 1.5875 };
            var screwPitch = screwPitchValues[selectedScrewPitch];

            var beltCalculator = new LeadScrewCalculator(stepAngle, microStep, screwPitch, GearRatio);


            var result = beltCalculator.Calculate();
                

            LSOutput.Text = result.ToString(CultureInfo.InvariantCulture);
        
        }
    }
}
