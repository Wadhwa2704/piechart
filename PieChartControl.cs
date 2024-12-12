using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace rad_assign2
{
    public partial class PieChartControl : UserControl
    {
        public List<float> Data { get; set; } = new List<float>();

        public PieChartControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Data == null || Data.Count == 0)
                return;

            float total = 0;
            foreach (var value in Data)
            {
                total += value;
            }

            if (total == 0)
                return;

            float startAngle = 0;
            Random random = new Random();
            List<Color> sliceColors = new List<Color>();

            for (int i = 0; i < Data.Count; i++)
            {
                float sweepAngle = Data[i] / total * 360;
                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                sliceColors.Add(color);

                using (Brush brush = new SolidBrush(color))
                {
                    e.Graphics.FillPie(brush, 10, 10, Width - 120, Height - 20, startAngle, sweepAngle);
                }

                startAngle += sweepAngle;
            }

            DrawLegend(e.Graphics, sliceColors, total);
        }

        private void DrawLegend(Graphics graphics, List<Color> sliceColors, float total)
        {
            int legendX = Width - 100;
            int legendY = 10;
            int legendBoxSize = 15;

            for (int i = 0; i < Data.Count; i++)
            {
                using (Brush brush = new SolidBrush(sliceColors[i]))
                {
                    graphics.FillRectangle(brush, legendX, legendY, legendBoxSize, legendBoxSize);
                }

                string legendLabel = $"{Math.Round((Data[i] / total) * 100, 1)}%";
                graphics.DrawString(legendLabel, this.Font, Brushes.Black, legendX + legendBoxSize + 5, legendY);

                legendY += legendBoxSize + 10;
            }
        }
    }
}
