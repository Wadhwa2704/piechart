using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace rad_assign2
{
    public partial class Form1 : Form
    {
        private PieChartControl pieChartControl = new PieChartControl();

        public Form1()
        {
            InitializeComponent();
            pieChartControl.Dock = DockStyle.Fill;
            chartDisplayPanel.Controls.Add(pieChartControl);
        }

        private void generateChartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(inputDataTextBox.Text))
                {
                    MessageBox.Show("Please enter values separated by commas.", "Invalid Input");
                    return;
                }

                var inputData = inputDataTextBox.Text.Split(',');
                List<float> data = new List<float>();

                foreach (var value in inputData)
                {
                    if (float.TryParse(value.Trim(), out float parsedValue))
                    {
                        data.Add(parsedValue);
                    }
                    else
                    {
                        MessageBox.Show($"Invalid number: '{value.Trim()}'", "Invalid Input");
                        return;
                    }
                }

                if (data.Count > 0)
                {
                    pieChartControl.Data = data;
                    pieChartControl.Invalidate();
                }
                else
                {
                    MessageBox.Show("Please enter at least one number.", "Invalid Input");
                    pieChartControl.Data.Clear();
                    pieChartControl.Invalidate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }
    }
}
