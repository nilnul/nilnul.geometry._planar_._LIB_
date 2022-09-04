using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid.draw_
{
	static public class _ArrowMiddleX
	{
		static public void DrawLineWithArrow(
			Graphics g,
			Color color,
			PointF start,
			PointF end,
			float arrowSize = 8f,
			bool filled = false
		)
		{
			//if (start == end) return;

			PointF mid = new PointF((start.X + end.X) / 2, (start.Y + end.Y) / 2);

			float angle =(float) (
				nilnul.geometry.planar.rotation_.Degree4dbl.FroRadian(
					Math.Atan2(end.Y - start.Y, end.X - start.X)
				//* (180 / Math.PI)
				)
			) ;

			var arrowHead = new GraphicsPath();
			arrowHead.AddLines(
				new PointF[]
				{
					new PointF(-arrowSize, -arrowSize/3),
					new PointF(0, 0),
					new PointF(-arrowSize, arrowSize/3) //y flipped
				}
			);
			if (filled)
			{
				arrowHead.CloseFigure();
			}
			var state = g.Save();
			using (Pen pen = new Pen(color, 0))
			{
				g.DrawLine(pen, start, end);
				g.TranslateTransform(
					mid.X,
					mid.Y);
				g.RotateTransform(angle);

				if (filled)
				{
					using (Brush fill = new SolidBrush(color))
					{
						g.FillPath(fill, arrowHead);
					}
				}
				g.DrawPath(pen, arrowHead);
			}
			g.Restore(state);
		}
	}
}

