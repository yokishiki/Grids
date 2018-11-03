using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grids
{
    public class Grid
    {
        public Cell[,] Cells { get; set; }
        public List<Cell> Obstacles { get; set; }
        public int CountN { get; set; }
        public int CountM { get; set; }
        public Cell Start { get; set; }
        public Cell Finish { get; set; }
        public List<Cell> Path { get; set; }

        public Grid(Cell[,] cells, int n, int m)
        {
            Cells = cells;
            CountN = n;
            CountM = m;
            Obstacles = new List<Cell>();
        }

        public void Draw(Bitmap bitmap)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                for (int i = 0; i < CountN; i++)
                    for (int j = 0; j < CountM; j++)
                        Cells[i,j].Draw(bitmap);
            }
        }

        public Cell GetCell(int x, int y)
        {
            for (int i = 0; i < CountN; i++)
            {
                for (int j = 0; j < CountM; j++)
                    if (Cells[i, j].IsPointInside(x, y))
                        return Cells[i, j];
            }
            return null;
        }

        public void AddObstacle(Cell cell)
        {
            Obstacles.Add(cell);
        }

        public void FindPath()
        {
            Cell[,] path = Algorithms.AStar(this);
            if (path == null)
                return;
            Cell current = Finish;
            Path = new List<Cell>();
            //Path.Add(Finish);
            while (current != Start)
            {
                var curPar = path[current.Coordinates.X, current.Coordinates.Y];
                current = Cells[curPar.Coordinates.X, curPar.Coordinates.Y];
                Path.Add(current);
                current = curPar;
            }
            Path.RemoveAt(Path.Count - 1);
        }
    }
}
