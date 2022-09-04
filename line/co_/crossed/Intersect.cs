using nilnul.geometry.planar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real;
using nilnul.num;
using nilnul.geometry.planar.grad_;

namespace nilnul.geometry.planar.line.co_.crossed
{
	/// <summary>
	/// two intersecting line to get the intersected point
	/// </summary>
	static public  class _CrossX
	{


		public static planar.Point1 _Point_ofAssumeCrossed(
			planar.Line a,
			planar.Line b

		)
		{
			//
			var determinantOfLine = nilnul.num.real.matrix_.square.to_.scalar_._DeterminantX.Determinant(
				new num.real.matrix_.square_.Two_Two(a.points.en.begin.x, a.points.en.begin.y, a.points.en.end.x, a.points.en.end.y).val
			);


			var determinantOfLine1 = DeterminantOfLine(b);
			var determinantOfLineX = DeterminantOfLineX(a);
			var determinantOfLineY = DeterminantOfLineY(a);
			var determinantOfLine1Y = DeterminantOfLineY(b);
			var determinantOfLine1X = DeterminantOfLineX(b);

			var denominator =new nilnul.num.real.matrix_.square_.Two_Two(
						determinantOfLineX, determinantOfLineY,
						determinantOfLine1X, determinantOfLine1Y

					).getDeterminant();


			return new planar.Point1(

					new nilnul.num.real.matrix_.square_.Two_Two(
						determinantOfLine, determinantOfLineX, determinantOfLine1, determinantOfLine1X).getDeterminant().ToReal()
					/
					denominator.ToReal()
					,
					new nilnul.num.real.matrix_.square_.Two_Two(
						determinantOfLine, determinantOfLineY, determinantOfLine1, determinantOfLine1Y
					).getDeterminant().ToReal()
					/ denominator

			);

		}

		public static planar.Point1 _Point_ofAssumeCrossed(LeadI lead, IArrow arrow)
		{
			return _Point_ofAssumeCrossed(
				new Line(lead)
				,
				new Line(arrow)
			);
		}

		public static planar.Point1 _Point_ofAssumeCrossed(
			planar.Ray line,
			planar.Tend segment

		)
		{
			return _Point_ofAssumeCrossed(new Line(line), new Line( segment.points) );
		}

		public static planar.Point1 _Point_ofAssumeCrossed(
			planar.Ray dir,
			planar.Ray dir1
		)
		{

			return _Point_ofAssumeCrossed(
				new Line( dir), new Line(dir1)
			);

		}
		public static planar.Point1 _Point_ofAssumeCrossed(
			planar.Ray line,
			planar.grad_.Arrow segment

		)
		{
			return _Point_ofAssumeCrossed(line, new planar.Tend(segment.ee.begin, segment.ee.end));
		}




	

		public static nilnul.num.RealI DeterminantOfLine(planar.Line a)
		{


			return

			new nilnul.num.real.matrix_.square_.Two_Two(a.points.en.begin.x, a.points.en.begin.y, a.points.en.end.x, a.points.en.end.y).getDeterminant();

		}
		public static nilnul.num.RealI DeterminantOfLineX(Line a)
		{

			return Determinant(a.begin.x, a.end.x);

		}
		public static nilnul.num.RealI DeterminantOfLineY(Line a)
		{

			return Determinant(a.begin.y, a.end.y);

		}

		public static nilnul.num.RealI DeterminantOfPoint(planar.PointI1 p)
		{
			return
new nilnul.num.real.matrix_.square_.Two_Two
				(p.x, new nilnul.num.real_.Quotient(1), p.y, new nilnul.num.real_.Quotient(1)
			).getDeterminant();

		}
		public static nilnul.num.RealI Determinant(nilnul.num.RealI x, nilnul.num.RealI y)
		{
			return new nilnul.num.real.matrix_.square_.Two_Two(
				x, new nilnul.num.real_.Quotient(1), y, new nilnul.num.real_.Quotient(1)
			).getDeterminant();

		}
	}
}
