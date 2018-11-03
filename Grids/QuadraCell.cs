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
            Side = Math.Sqrt(2) / 2.0 * radius;
        }

        public override bool IsPointInside(int x, int y)
        {
            throw new NotImplementedException();
        }

        protected override PointF[] VertexCoords()
        {
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
