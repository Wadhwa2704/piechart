namespace rad_assign2
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
            inputDataTextBox = new TextBox();
            generateChartButton = new Button();
            chartDisplayPanel = new Panel();
            SuspendLayout();
            // 
            // inputDataTextBox
            // 
            inputDataTextBox.Location = new Point(197, 135);
            inputDataTextBox.Name = "inputDataTextBox";
            inputDataTextBox.Size = new Size(200, 27);
            inputDataTextBox.TabIndex = 0;
            // 
            // generateChartButton
            // 
            generateChartButton.Location = new Point(221, 195);
            generateChartButton.Name = "generateChartButton";
            generateChartButton.Size = new Size(145, 29);
            generateChartButton.TabIndex = 1;
            generateChartButton.Text = "Generate Chart";
            generateChartButton.UseVisualStyleBackColor = true;
            generateChartButton.Click += generateChartButton_Click;
            // 
            // chartDisplayPanel
            // 
            chartDisplayPanel.Location = new Point(403, 12);
            chartDisplayPanel.Name = "chartDisplayPanel";
            chartDisplayPanel.Size = new Size(345, 376);
            chartDisplayPanel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chartDisplayPanel);
            Controls.Add(generateChartButton);
            Controls.Add(inputDataTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDataInput;
        private Button btnGenerate;
        private Panel panelChart;
        private Label label1;
        private TextBox inputDataTextBox;
        private Button generateChartButton;
        private Panel chartDisplayPanel;
    }
}
