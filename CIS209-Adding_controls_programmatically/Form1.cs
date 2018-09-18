using System;
using System.Drawing;
using System.Windows.Forms;

namespace CIS209_Adding_controls_programmatically
{
    public partial class Form1 : Form
    {
        // My Controls
        private Label lbl1 = new Label();
        private TextBox tbx1 = new TextBox();
        private Button btn1 = new Button();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl1.Text = "My label";
            lbl1.Location = new Point(10, 25);

            tbx1.Location = new Point(150, 25);

            btn1.Text = "My Button";
            btn1.Location = new Point(10, 50);

            // Add controls
            Controls.Add(lbl1);
            Controls.Add(tbx1);
            Controls.Add(btn1);
        }
    }
}
