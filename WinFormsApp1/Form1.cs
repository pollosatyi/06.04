using System.Drawing;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;
        private bool[,] field;
        private int rows;
        private int columns;

        public Form1()
        {
            InitializeComponent();
        }
        private void StarGame()
        {
            if (timer1.Enabled) return;

            NumResolution.Enabled = false;
            NumDensity.Enabled = false;


            resolution = (int)NumResolution.Value;
            rows=pictureBox1.Height/resolution;
            columns=pictureBox1.Width/resolution;
            field=new bool[rows, columns];
            //Random rnd = new Random();
            //for (int i = 0; i < rows; i++)
            //{
            //    for(int j = 0; j < columns; j++)
            //    {
            //        field[i, j] = rnd.Next((int)NumDensity.Value)==0;
            //    }
            //}
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j=0; j < columns; j++)
                {
                    field[i, j] = rnd.Next((int)NumDensity.Value) == 0;
                }
            }
            // graphics.FillRectangle(Brushes.Crimson, 0, 0, resolution, resolution);
        }
        private void StopGame() {
            if (!timer1.Enabled) return;
            timer1.Stop();
            NumResolution.Enabled = true;
            NumDensity.Enabled = true;

        }

        private void NextGeneration()
        {
            graphics.Clear(Color.Black);
            var newfield= new bool[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    var count=Count(i,j);
                    var haslife = field[i,j];
                    if (!haslife && count == 3)
                    {
                        newfield[i, j] = true;
                    }
                    else if (haslife && count > 3 || count < 2)
                    {
                        newfield[i, j] = false;
                    }
                    else
                    {
                        newfield[i, j] = field[i, j];
                    }
                    if (field[i, j])
                    {
                        graphics.FillRectangle(Brushes.Crimson,i*resolution,j*resolution,resolution,resolution);
                    }
                }
                
            }
            field = newfield;
            pictureBox1.Refresh();

        }



        private  int Count(int x, int y)
        {
            int count = 0;
            for(int i = -1; i < 2; i++)
            {
                for(int j = -1; j < 2; j++)
                {
                    int col = (x + i+columns)%columns;
                    int row = (y+ j+rows)%rows;
                    var isSelfChecking = col == x && col == y;
                    var haslife = field[col,row];
                    if(haslife && !isSelfChecking)
                    {
                        count++;
                    }
                }
            }
            return 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void BStart_Click(object sender, EventArgs e)
        {
            StarGame();
        }

        private void BStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
