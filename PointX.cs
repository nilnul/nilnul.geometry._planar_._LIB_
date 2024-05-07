using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	static public class PointX
	{
		public static string PointToString(this PointF x)
		{
			return string.Format("{0},{1}", x.X.ToString(), x.Y);
		}

		public static string PointFToString(float x, float y)
		{

			return string.Format("{0},{1}", x, y);
		}

		public static string PointFToString(float x)
		{

			return PointFToString(x, x);
		}

		public static PointF Down(this PointF point, float dy)
		{
			return new PointF(point.X, point.Y - dy);
		}

		static public Point Minus(this Point a, Point b)
		{
			return nilnul.geometry.planar.point.co.band_.Minus.Singleton.combine(a, b);
		}




		static public Point1 ToPoint(this PointI1 point)
		{
			if (point is Point1 p)
			{
				return p;
			}
			return new Point1(point);
		}
		static public PointF ToPointF(this Point4dblI point) {
			return new PointF(
				(float)point.x
				,
				(float)point.y
			);
		}
		static public Complex ToComplex(this Point4dblI point) {
			return new Complex(
				point.x
				,
				point.y
			);
		}

		[Obsolete(nameof(ToImpl))]
		static public Point4dbl ToOrthogonal(this Point4dblI point)
		{
			return point switch
			{
				Point4dbl a => a
				 ,
				_ => new Point4dbl(point.x, point.y)
			}
			;
		}

		/// <summary>
		/// to an implementation, that is, class or struct, 
		/// </summary>
		/// <param name="point"></param>
		/// <returns></returns>
		static public Point4dbl ToImpl(this Point4dblI point)
		{
			return point switch
			{
				Point4dbl a => a
				 ,
				_ => new Point4dbl(point.x, point.y)
			}
			;
		}

		static public string ToTxt_bare(this Point4dblI point,string separator = ",")
		{
			return string.Format("{0}{1}{2}", point.x, separator, point.y);

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Point4dbl ToPoint(this Complex c)
		{
			return c;
		}
	}

}

