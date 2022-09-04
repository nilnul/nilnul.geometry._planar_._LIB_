using nilnul.geometry._2d.dir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry._2d.line.pair.be.crossed.op
{
	public partial class Intersect
	{
		public static point.PointInDouble Eval(

			dir.Dir dir,
			dir.Arrow arrow
			
		) { 
				return Eval(
				new Line(dir),new Line(arrow.val)	
			);
	
		}


		public static point.PointInDouble Eval(
			dir.Dir dir,
			dir.Dir dir1
		) {

			return Eval(
				new Line(dir),new Line(dir1)	
			);
		
		}
		public static point.PointInDouble Eval(
			Line a,
			Line b
			
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


			return new point.PointInDouble(
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

		

		public static point.PointInDouble Eval(
			dir.Dir line,
			SegmentOrPoint segment

		) {

			return Eval( new Line(line),segment );
		
		}



		public static point.PointInDouble Eval(
			Line line,
			SegmentOrPoint segment
			
		) {


			var point = Eval(line, new Line(segment));

			if (segment.contains(point))
			{
				return point;
				
			}
			return null;
 
		
		}

		public static double DeterminantOfLine(Line a) {
		
				return  nilnul.num.real.matrix.doubleElement.SquareMatrix.Create(a.point.x, a.point.y, a.point1.x, a.point1.y).determinant;
	
		}
		public static double DeterminantOfLineX(Line a) {
		
				return Determinant(a.point.x,a.point1.x);
	
		}
		public static double DeterminantOfLineY(Line a) {
		
				return Determinant(a.point.y,a.point1.y);
	
		}

		public static double DeterminantOfPoint(point.PointInDouble p) {
			return nilnul.num.real.matrix.square.InDouble.Create(p.x, 1, p.y, 1).determinant;
		
		}
		public static double Determinant(double x, double y) {
			return nilnul.num.real.matrix.square.InDouble.Create(x, 1, y, 1).determinant;
		
		}
	}
}
