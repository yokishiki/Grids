using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grids
{
    public partial class GridApp : Form
    {
        public GridApp()
        {
            InitializeComponent();
            cbGridType.SelectedIndex = 0;
            pictureBox1.Focus();
            pictureBox1.Image = new Bitmap(600, 600);
        }

        Grid grid;
        bool isAddObstacle = false;
        bool isSetStart = false;
        bool isSetFinish = false;

        public void DrawStartCells()
        {
            double a = 20f;
            double x0 = a;
            double y0 = a;
            double dy = 1.5 * a;
            double dx = Math.Sqrt(3)  * a;
            int n = Convert.ToInt32(numericUpDownX.Value);
            int m = Convert.ToInt32(numericUpDownY.Value);
            Cell[,] cells;
            if (cbGridType.SelectedIndex == 0)
            {
                Grid.IsHexa = true;
                cells = new HexaCell[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        cells[i, j] = new HexaCell(new PointF((float)(x0 + dx * j + i % 2 * a * Math.Sqrt(3) / 2.0), (float)(y0 + dy * i)),
                            new Point(i, j), a);
                    }
                }
            }
            else
            {
                a *= 2;
                Grid.IsHexa = false;
                cells = new QuadraCell[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        cells[i, j] = new QuadraCell(new PointF((float)(i *a + a/2), (float)(j*a +a/2)), 
                            new Point(i, j), a);
                    }
                }

            }
            grid = new Grid(cells, n, m);
            Draw();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //Cell point = grid.GetCell(e.X, e.Y);
            //if (point == null) return;
            //for (int i = 0; i < grid.CountN; i++)
            //    for (int j = 0; j < grid.CountM; j++)
            //        if (point.Coordinates.X == i && point.Coordinates.Y == j)
            //        {
            //            grid.Cells[i, j].PrevColor = grid.Cells[i, j].FillColor == Color.LightCoral ? 
            //                grid.Cells[i, j].PrevColor : grid.Cells[i, j].FillColor;
            //            grid.Cells[i, j].FillColor = Color.LightCoral;
            //        }
            //        else
            //        {
            //            grid.Cells[i, j].FillColor = grid.Cells[i, j].FillColor == Color.LightCoral ?
            //                grid.Cells[i, j].PrevColor : grid.Cells[i, j].FillColor;
            //        }
            //Draw();
        }

        private void Draw()
        {
            grid.Draw((Bitmap)pictureBox1.Image);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Cell point = grid.GetCell(e.X, e.Y);
            if (point == null)
            {
                return;
            }

            if (isAddObstacle)
            {
                if (point.FillColor == Color.DarkGray)
                {
                    for (int i = 0; i < grid.Obstacles.Count; i++)
                        if (point.Coordinates == grid.Obstacles[i].Coordinates)
                        {
                            grid.Obstacles.RemoveAt(i);
                            grid.Cells[point.Coordinates.X, point.Coordinates.Y].FillColor = Color.LightGray;
                        }
                }
                else
                {
                    point.PrevColor = Color.LightGray;
                    point.FillColor = Color.DarkGray;
                    grid.AddObstacle(point);
                }
            }

            if (isSetStart)
            {
                if (point.FillColor == Color.DarkOrange)
                    return;
                point.PrevColor = Color.LightGray;
                point.FillColor = Color.Magenta;
                grid.Start = point;
                isSetStart = false;
            }

            if (isSetFinish)
            {
                if (point.FillColor == Color.DarkOrange)
                    return;
                point.PrevColor = Color.LightGray;
                point.FillColor = Color.CadetBlue;
                grid.Finish = point;
                isSetFinish = false;
            }

            Draw();
        }

        private void buttonAddObstacle_Click(object sender, EventArgs e)
        {
            if (isSetStart)
                isSetStart = false;

            if (isSetFinish)
                isSetFinish = false;

            if (isAddObstacle)
            {
                buttonAddObstacle.Text = "Add obstacle";
                isAddObstacle = false;
            }
            else
            {
                buttonAddObstacle.Text = "Not add obstacle";
                isAddObstacle = true;
            }
        }

        private void buttonSetStartCell_Click(object sender, EventArgs e)
        {
            if (isAddObstacle)
            {
                isAddObstacle = false;
                buttonAddObstacle.Text = "Add obstacle";
            }
            isSetStart = true;
        }

        private void SetFinish_Click(object sender, EventArgs e)
        {
            if (isAddObstacle)
            {
                isAddObstacle = false;
                buttonAddObstacle.Text = "Add obstacle";
            }
            isSetFinish = true;
        }

        private void buttonDrawGrid_Click(object sender, EventArgs e)
        {
            DrawStartCells();
        }

        private void buttonFindPath_Click(object sender, EventArgs e)
        {
            if (grid.Start == null || grid.Finish == null)
                return;
            grid.FindPath();
            foreach (var cell in grid.Path)
            {
                cell.FillColor = Color.LightSalmon;
                cell.PrevColor = Color.LightGray;
            }
            Draw();
        }
    }
}
