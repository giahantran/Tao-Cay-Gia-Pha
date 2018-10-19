using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TestingGP
{
    class TreeDrower
    {
        private const int Radius = 20;
        private const int VerticalMarging = 100;
        private const int HorizontalMarging = 50;
        private readonly Font _font = SystemFonts.DefaultFont;

        public Size GetSize(Tree tree)
        {
            var height = Tree.Height(tree.GetTop()) + 1;
            var width = Math.Pow(2, height - 1);

            var heightPx = (height - 1) * VerticalMarging + 2 * Radius;
            var widthPx = (width - 1) * HorizontalMarging + 2 * Radius;
            return new Size((int)widthPx, heightPx);
        }

        public void Draw(Graphics g, TreeMember knot, Rectangle rect)
        {
            var newRect = new Rectangle(rect.Left + Radius, rect.Top + Radius, rect.Width - 2 * Radius, rect.Height - 2 * Radius);
            DrowWithoutBorders(g, knot, newRect);
        }
        private Point DrowWithoutBorders(Graphics g, TreeMember knot, Rectangle rect)
        {
            var center = new Point(rect.Left + rect.Width / 2, rect.Top);
            if (knot == null)
            {
                DrawKnot(g, null, center.X, center.Y);
                return center;
            }

            DrawKnot(g, knot.Value, center.X, center.Y);

            var subSize = new Size((rect.Width - HorizontalMarging) / 2, rect.Height - VerticalMarging);
            var leftRect = new Rectangle(new Point(rect.Left, rect.Top + VerticalMarging), subSize);
            var rightRect = new Rectangle(new Point(rect.Left + (rect.Width + HorizontalMarging) / 2, rect.Top + VerticalMarging), subSize);

            var leftPoint = DrowWithoutBorders(g, knot.Left, leftRect);
            var rightPoint = DrowWithoutBorders(g, knot.Right, rightRect);

            DrawLine(g, center, leftPoint);
            DrawLine(g, center, rightPoint);

            return center;
        }

        private void DrawLine(Graphics g, Point p1, Point p2)
        {
            var pen = new Pen(Color.Black);

            var alpha = atg(p2.Y - p1.Y, p2.X - p1.X);
            var p3 = new Point((int)(p1.X + Radius * Math.Cos(alpha)), (int)(p1.Y + Radius * Math.Sin(alpha)));
            var p4 = new Point((int)(p2.X - Radius * Math.Cos(alpha)), (int)(p2.Y - Radius * Math.Sin(alpha)));
            g.DrawLine(pen, p3, p4);
        }

        private double atg(double dy, double dx)
        {
            var k = dy / dx;
            var alpha = Math.Atan(k) + ((dx < 0) ? Math.PI : 0);
            return alpha;
        }

        private void DrawKnot(Graphics g, int? value, int centerX, int centerY)
        {
            var strValue = (value == null) ? "null" : value.ToString();
            g.DrawEllipse(Pens.Black, new Rectangle(centerX - Radius, centerY - Radius, Radius * 2, Radius * 2));
            var textSize = TextRenderer.MeasureText(strValue, _font);
            g.DrawString(strValue, SystemFonts.IconTitleFont, new SolidBrush(Color.Black), centerX - textSize.Width / 2, centerY - textSize.Height / 2);
        }
    }
}
