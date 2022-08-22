namespace Final_Project_OOP
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving =false;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            pen = new Pen(Color.Black, 5);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pen.Color = pictureBox.BackColor;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
            
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;

        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x!=-1 && y!=-1)
            {
                g.DrawLine(pen,new Point(x,y),e.Location);
                x = e.X;
                x = e.Y;
            }

        }
    }
}