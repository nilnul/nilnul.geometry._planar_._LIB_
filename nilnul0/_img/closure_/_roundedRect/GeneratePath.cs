using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.point.op_.unary_;
using nilnul.geometry.planar.point.op_;

namespace nilnul._img.closure_._roundedRect
{
	public class GeneratePath
	{


		static public GraphicsPath GetClosure(RectangleF rect,

			float radiusRatio
		)
		{


			var vRadius = radiusRatio * rect.Height;
			var hRadius = radiusRatio * rect.Width;

			//var vDiameter = vRadius * 2;
			//var hDiameter = hRadius * 2;


			//var upperEllipseY = rect.Height - vDiameter;

			//var furtherEllipseX = rect.Width - hDiameter;

			//var hLineFurther = rect.Width - hRadius;
			//var vLineUpper = rect.Height - vRadius;
			GraphicsPath graphPath = new GraphicsPath();

			//Action<float, float, float> addArc = (float x, float y, float inital) =>
			//{

			//	graphPath.AddArc(
			//		x, y, hDiameter, vDiameter, inital, 90
			//	);

			//};


			var points = nilnul.geometry.planar._rect.Extensions.GetPath(
					rect
				).ToArray();

			var p0h = nilnul.geometry.planar.point.op_.unary_._ShiftX.Shift(points[0], hRadius);

			var p1h = points[1].Shift(-hRadius);

			var p1v = points[1].Raise(vRadius);

			var p2v = points[2].Raise(-vRadius);

			var p2h = points[2].Shift(-hRadius);

			var p3h = points[3].Shift(hRadius);
			var p3v = points[3].Raise(-vRadius);

			var p0v = points[0].Raise(vRadius);

	Action<PointF ,PointF> addArc = (PointF start, PointF end) =>
				{
					graphPath.AddPath(
					nilnul.geometry.planar.ellipse.Extensions.CreateQuarter(start, end),true );

				};

			Action<PointF, PointF> addLine = (x, y) => {
				graphPath.AddLine(x,y);
			};

			addArc(p0v, p0h);
			addLine(p0h, p1h);

			addArc(p1h, p1v);
			addLine(p1v, p2v);

			addArc(p2v, p2h);
			addLine(p2h, p3h);

			addArc(p3h, p3v);
			addLine(p3v, p0v);
			//addArc(0, 0, -90);


			//graphPath.AddLine(0, vRadius, 0, vLineUpper);


			//addArc(0, vLineUpper, 180);

			//graphPath.AddLine(hRadius, rect.Height, hLineFurther, rect.Height);

			//addArc(hLineFurther, rect.Height, 90);
			////further down
			//graphPath.AddLine(rect.Width, vLineUpper, rect.Width, vRadius);

			///// further Lower

			//addArc(
			//	furtherEllipseX, 0, 0

			//);

			//graphPath.AddLine(furtherEllipseX, 0, hRadius, 0);


			graphPath.CloseFigure();
			return graphPath;
		}
	}
}
