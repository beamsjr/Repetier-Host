﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RepetierHost.view
{
    public partial class BeltCalculator : Form
    {
        public BeltCalculator()
        {
            InitializeComponent();
        }

        private void BeltCalculator_Load(object sender, EventArgs e)
        {

        }

        private void BeltCalculatorCalculateButton_Click(object sender, EventArgs e)
        {
            var selectedStepAngle = MotorStepAngleInput.SelectedIndex;
            var selectedMicrostepValue = MotorMicrosteppingInput.SelectedIndex;
            var selectedBeltPitch = BeltPitchInput.SelectedIndex;
            
            int toothCount;

            if (!int.TryParse(ToothCountInput.Text, out toothCount) )
            {
                StepsPerMMOutput.Text ="Tooth Count must be int";
                return;
            }
            

            var stepAngles = new List<double>{1.8,0.9,7.5};
            var stepAngle = stepAngles[selectedStepAngle];

            var microStepValues = new List<double>() {1, 0.5, 0.25, 0.125, 0.0625};
            var microstep = microStepValues[selectedMicrostepValue];

            var beltPitchValues = new List<double>() {2, 2.03, 2.5, 3, 5, 5.08};
            var beltPitch = beltPitchValues[selectedBeltPitch];

            var result = ((360/stepAngle)*(1/microstep))/(beltPitch*toothCount);

            StepsPerMMOutput.Text = Math.Round(result, 4).ToString(CultureInfo.InvariantCulture);
        }
    }
}
