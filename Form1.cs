namespace paint
{
    public partial class Form1 : Form
    {
        private bool isdrawing = false;
        private Point previousPoint;
        private Color currentColor = Color.Black;
        private int brushsize = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void drowingpanel_MouseDown(object sender, MouseEventArgs e)
        {
            isdrawing = true;
            previousPoint = e.Location;
        }

        private void drowingpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isdrawing)
            {
                using (Graphics g = drawingpanel.CreateGraphics())
                {
                    Pen pen = new Pen(currentColor, brushsize);
                    g.DrawLine(pen, previousPoint, e.Location);
                    previousPoint = e.Location;
                }
            }
        }

        private void drowingpanel_MouseUp(object sender, MouseEventArgs e)
        {
            isdrawing = false;
        }

        private void redbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (redbtn.Checked)
            {
                currentColor = Color.Red;
            }
        }

        private void bluebtn_CheckedChanged(object sender, EventArgs e)
        {
            if (bluebtn.Checked)
            {
                currentColor = Color.Blue;
            }
        }

        private void greenbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (greenbtn.Checked)
            {
                currentColor = Color.Green;
            }
        }

        private void blackbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (blackbtn.Checked)
            {
                currentColor = Color.Black;
            }
        }

        private void smallbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (smallbtn.Checked)
            {
                brushsize = 2;
            }
        }

        private void mediumbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (mediumbtn.Checked)
            {
                brushsize = 5;
            }
        }

        private void largebtn_CheckedChanged(object sender, EventArgs e)
        {
            if (largebtn.Checked)
            {
                brushsize = 12;
            }
        }

        private void eraserbtn_Click(object sender, EventArgs e)
        {
            currentColor = drawingpanel.BackColor;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            drawingpanel.Invalidate();
        }
    }
}
