using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve.stream_.hilbert_.byPoints_
{
	/// <summary>
	/// </summary>
	static public class _AroundOriginX
	{
		/// <summary>
		/// using screed coordiantes. center around origin
		/// </summary>
		/// <param name="g">assume it's square</param>
		static public List<Point4dbl> _Points(

			int ord
			,
			double edge


		)
		{
			if (ord == 0)
			{
				return new List<Point4dbl>() { new Point4dbl() };
			}

			var newOrd = ord - 1;

			var halfEdge = edge / 2;
			var quarterEdge = halfEdge / 2;

			var negQuarterEdge = -quarterEdge;

			var r = new List<Point4dbl>();

			var subSquarePoints = _Points(
				newOrd
				,
				halfEdge
			);



			/// lowerLeft
			r.AddRange(
				subSquarePoints.Select(
					p => new Point4dbl(-p.y, -p.x) + new geometry.planar.Vect4dbl(
						-quarterEdge
						,
						quarterEdge
					)
				)
			);



			///upperLeft
			var upperLeftPoints = subSquarePoints.Select(
				p => p + new geometry.planar.Vect4dbl(
					-quarterEdge
					,
					-quarterEdge
				)
			);

			r.AddRange(
				upperLeftPoints
			);


			/// upperRight
			r.AddRange(
				subSquarePoints.Select(
					p => p + new geometry.planar.Vect4dbl(
						quarterEdge
						,
						-quarterEdge
					)
				)
			);

			/// lowerRight
			r.AddRange(
				subSquarePoints.Select(
					p => new Point4dbl(p.y, p.x) + new geometry.planar.Vect4dbl(
						quarterEdge
						,
						quarterEdge
					)
				)
			);

			return r;



		}
		private static List<Point4dbl> _Points(int ord, NonnegOfDoubleI edge)
		{
			return _Points(ord, edge.realee.ee);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="g">assume it's square</param>
		/// <param name="ord">how many times we recur</param>
		static public IEnumerable<Point4dbl> Draw(

			int ord
			,

			nilnul.geometry.planar.tope_.bloc_.Square4dbl bloc

		//,
		//double rotationInDegree = 0
		)
		{
			return _Points(ord, bloc.edge).Select(p => p + bloc.center);//.ToList();
		}


		static public void Draw(
		Graphics g
		,
		int ord
		,

		nilnul.geometry.planar.tope_.bloc_.Square4dbl bloc
		,
		Pen pen
	//,
	//double rotationInDegree = 0
	)
		{
			var p = Draw(
				ord, bloc
			).Select(d => d.toPointF()).ToArray();

			if (p.Skip(1).Any())
			{
				g.DrawLines(pen, p);


			}
			else
			{
				var pieSize = 10;
				var pieSizeHalf = 10 / 2;
				var s = p.Single();
				g.FillEllipse( new SolidBrush(pen.Color), new RectangleF(s.X - pieSizeHalf, s.Y - pieSizeHalf, pieSize, pieSize));
			}
		}

	}
}
