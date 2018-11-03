using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grids
{
    class QuadraCell : Cell
    {
        public QuadraCell(PointF center, Point coordinates, double radius, Color? fillColor = null, Color? lineColor = null) 
            : base(center, coordinates, radius, fillColor, lineColor)
        {
            
        }

        public override bool IsPointInside(int x, int y)
        {
            return (Coordinates.X * Radius < x && (Coordinates.X * Radius + Radius)  > x &&
                Coordinates.Y * Radius < y &&( Coordinates.Y * Radius + Radius) > y);
        }

        protected override PointF[] VertexCoords()
        {
            Side = Math.Sqrt(2) / 2.0 * Radius;
            PointF[] vertexCoords = new PointF[4];
            for (int i = 0; i < 4; i++)
            {
                double alpha = Math.PI / 4.0 * (2 * i - 1);
                vertexCoords[i] = new PointF((float)(Center.X + Side * Math.Cos(alpha)),
                    (float)(Center.Y + Side * Math.Sin(alpha)));
            }
            return vertexCoords;
        }
    }
}
