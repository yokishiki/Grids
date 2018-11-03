using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grids
{
    class HexaCell : Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public HexaCell() : base() { }
        public HexaCell(PointF center, Point coordinates, double radius, Color? fillColor = null, Color? lineColor = null) 
            : base(center, coordinates, radius, fillColor, lineColor)
        {
            Side = radius;
        }

        protected override PointF[] VertexCoords()
        {
            PointF[] vertexCoords = new PointF[6];
            for (int i = 0; i < 6; i++)
            {
                double alpha = Math.PI / 6.0 * (2 * i - 1);
                vertexCoords[i] = new PointF((float)(Center.X + Radius * Math.Cos(alpha)),
                    (float)(Center.Y + Radius * Math.Sin(alpha)));
            }
            return vertexCoords;
        }

        public override bool IsPointInside(int xx, int yy)
        {
            if ((Center.X - xx) * (Center.X - xx) + (Center.Y - yy) * (Center.Y - yy) > Radius * Radius)
                return false;
            double x = xx - Center.X;
            double y = yy - Center.Y;
            double a = -0.5 * Radius;
            double b = Math.Sqrt(3) / 2.0 * Radius;
            double c = -Math.Sqrt(3) / 2.0 * Radius * Radius;
            if (a * x + b * y + c <= 0 && -a * x + b * y + c <= 0 && a * x + b * y - c >= 0 && -a * x + b * y - c >= 0
                && x >= -Math.Sqrt(3) / 2.0 * Radius && x <= Math.Sqrt(3) / 2.0 * Radius)
                return true;
            return false;
        }
    }
}
