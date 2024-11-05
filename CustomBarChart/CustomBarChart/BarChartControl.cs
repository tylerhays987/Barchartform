using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class BarChartControl : Control
{
    private int[] values;

    public void SetValues(int[] values)
    {
        this.values = values;
        Invalidate(); 
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        if (values == null || values.Length == 0) return;

        Graphics g = e.Graphics;
        int width = ClientSize.Width / values.Length;
        int maxHeight = ClientSize.Height;

        
        int maxValue = Math.Max(1, Math.Abs(values.Max()));

        for (int i = 0; i < values.Length; i++)
        {
            
            int barHeight = (int)((double)Math.Abs(values[i]) / maxValue * maxHeight);
            Brush brush = new SolidBrush(Color.FromArgb(255, (i * 50) % 255, 100, 100)); 

            
            int yPosition = values[i] < 0 ? (maxHeight / 2) : (maxHeight / 2 - barHeight);

            
            g.FillRectangle(brush, i * width, yPosition, width - 2, barHeight);
        }

        
        g.DrawLine(Pens.Black, ClientSize.Width / 2, 0, ClientSize.Width / 2, ClientSize.Height);
    }
}