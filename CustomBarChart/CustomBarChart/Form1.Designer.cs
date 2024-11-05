namespace CustomBarChart
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
            txtInput = new TextBox();
            btnDrawGraph = new Button();
            barChartPanel = new Panel();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 22);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(363, 23);
            txtInput.TabIndex = 0;
            // 
            // btnDrawGraph
            // 
            btnDrawGraph.Location = new Point(462, 22);
            btnDrawGraph.Name = "btnDrawGraph";
            btnDrawGraph.Size = new Size(175, 23);
            btnDrawGraph.TabIndex = 1;
            btnDrawGraph.Text = "Draw Graph";
            btnDrawGraph.UseVisualStyleBackColor = true;
            btnDrawGraph.Click += btnDrawGraph_Click;
            // 
            // barChartPanel
            // 
            barChartPanel.BorderStyle = BorderStyle.Fixed3D;
            barChartPanel.Location = new Point(196, 165);
            barChartPanel.Name = "barChartPanel";
            barChartPanel.Size = new Size(200, 100);
            barChartPanel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(barChartPanel);
            Controls.Add(btnDrawGraph);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnDrawGraph;
        private Panel barChartPanel;
    }
}
