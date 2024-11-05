using System;
using System.Linq;
using System.Windows.Forms;

namespace CustomBarChart // Adjust according to your actual namespace
{
    public partial class Form1 : Form
    {
        private BarChartControl barChartControl;

        public Form1()
        {
            InitializeComponent();

            
            barChartControl = new BarChartControl
            {
                Dock = DockStyle.Fill
            };
            barChartPanel.Controls.Add(barChartControl);
        }

        private void btnDrawGraph_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            if (string.IsNullOrWhiteSpace(input)) return;

            
            var values = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(x => int.TryParse(x, out var num) ? num : 0)
                               .ToArray();

            barChartControl.SetValues(values);
        }
    }
}