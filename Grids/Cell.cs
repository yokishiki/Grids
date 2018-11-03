using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grids
{
    abstract public class Cell
    {
        public PointF Center { get; set; }
        public double Radius { get; set; }
        public Color LineColor { get; set; }
        public Color FillColor { get; set; }
        public Color PrevColor { get; set; }
        public PointF[] Vertices { get; set; }
        public double Side { get; set; }
        public Point Coordinates { get; set; }

        public Cell() { }
        public Cell(PointF center, Point coordinates, double radius, Color? fillColor = null,  Color? lineColor = null)
        {
            Center = center;
            Radius = radius;
            FillColor = fillColor == null ? Color.LightGray : fillColor.Value;
            LineColor = lineColor == null ? Color.DarkCyan : lineColor.Value;
            PrevColor = FillColor;
            Vertices = VertexCoords();
            Coordinates = coordinates;
        }

        public void Draw(Bitmap bitmap)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                SolidBrush sb = new SolidBrush(FillColor);
                Pen pen = new Pen(LineColor);
                g.FillPolygon(sb, Vertices);
                g.DrawPolygon(pen, Vertices);
            }
        }

        protected abstract PointF[] VertexCoords();

        public abstract bool IsPointInside(int x, int y);
    }
}
