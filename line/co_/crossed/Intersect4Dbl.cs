using nilnul.geometry.planar.grad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.line.co_.crossed
{
	public  class Cross4Dbl
	{

		public static Point4dbl _Eval_twoIntersectingLines(
			LineDbl a,
			LineDbl b
			
		) { 
			//
			var determinantOfLine =  nilnul.num.real.matrix.doubleElement.SquareMatrix.Create(a.point.x, a.point.y, a.point1.x, a.point1.y).determinant;
			var determinantOfLine1 = DeterminantOfLine(b);
			var determinantOfLineX = DeterminantOfLineX(a);
			var determinantOfLineY= DeterminantOfLineY(a);
			var determinantOfLine1Y= DeterminantOfLineY(b);
			var determinantOfLine1X= DeterminantOfLineX(b);

			var denominator=					nilnul.num.real.matrix.square.InDouble.Create(
						determinantOfLineX,determinantOfLineY,
						determinantOfLine1X,determinantOfLine1Y
					
					).determinant;


			return new Point4dbl(
					nilnul.num.real.matrix.square.InDouble.Create(
						determinantOfLine,determinantOfLineX,determinantOfLine1,determinantOfLine1X).determinant
					/
					denominator
					,
					nilnul.num.real.matrix.square.InDouble.Create(
						determinantOfLine,determinantOfLineY,determinantOfLine1,determinantOfLine1Y
					).determinant
					/denominator

			);
		
		}

		public static Point4dbl _Eval_twoIntersectingLines(IRayDbl dirShoot,grad_.skid_.ByPoints4Dbl  arrowBase)
		{
			return _Eval_twoIntersectingLines(
				new LineDbl(dirShoot)
				,
				new LineDbl(arrowBase)
			); ;
		}

		public static double DeterminantOfLine(LineDbl a) {
		
				return  nilnul.num.real.matrix.doubleElement.SquareMatrix.Create(a.point.x, a.point.y, a.point1.x, a.point1.y).determinant;
	
		}
		public static double DeterminantOfLineX(LineDbl a) {
		
				return Determinant(a.point.x,a.point1.x);
	
		}
		public static double DeterminantOfLineY(LineDbl a) {
		
				return Determinant(a.point.y,a.point1.y);
	
		}

		public static double DeterminantOfPoint(Point4dbl p) {
			return nilnul.num.real.matrix.square.InDouble.Create(p.x, 1, p.y, 1).determinant;
		
		}
		public static double Determinant(double x, double y) {
			return nilnul.num.real.matrix.square.InDouble.Create(x, 1, y, 1).determinant;
		
		}
		public static Point4dbl _Eval_twoIntersectingLines(
			planar.IRayDbl dir,
			planar.IRayDbl dir1
		)
		{

			return _Eval_twoIntersectingLines(
				new LineDbl(dir), new LineDbl(dir1)
			);

		}
	}
}
