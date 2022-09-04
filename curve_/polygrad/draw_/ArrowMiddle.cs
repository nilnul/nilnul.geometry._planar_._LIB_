using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.polygrad.draw_
{
	static public class _ArrowMiddleX
	{
		public static void _AssumePolygrad(
			Graphics graphics
			,
			Point[] points
		)
		{
			for (int i = 0; i < (points.Length - 1); i++)
			{
				Point p1 = points[i];
				Point p2 = points[i + 1];
				graphics.DrawLine(Pens.Black, p1, p2);

				float angle =(float) planar.grad._DirectionX.GtNegPiLePi(p1, p2);
				Point mid = planar.tend._MidX.Mid(p1, p2);
				var s= graphics.Save();

				graphics.TranslateTransform(mid.X, mid.Y);
				graphics.RotateTransform(angle);
				graphics.RotateTransform(135);
				graphics.DrawLine(Pens.Black, new Point(0, 0), new Point(8, 0));
				graphics.RotateTransform(-270);
				graphics.DrawLine(Pens.Black, new Point(0, 0), new Point(8, 0));
				graphics.ResetTransform();
				graphics.Restore(s);

			}
		}
	}
}
