using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.op_.unary_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///
	///    
	/// </remarks>
	static public class _ScaleX
	{

	


		static public planar.Vect4dbl Scale(this planar.Vect4dblI vector, double directionOfBoard) {

			return new planar.Vect4dbl(
				vector.point.x*directionOfBoard
				,
				vector.point.y*directionOfBoard
			);
		}
		public static planar.Vect4dbl Scale(Vect4dbl vect, double t)
		{
			return Scale(
				(Vect4dblI)vect,t
			);

			;
		}

		public static Point4dbl ScaleAsPoint(double v, Vect4dblI vector)
		{
			return new planar.Point4dbl(
				vector.point.x*v
				,
				vector.point.y*v
			);
		}
		public static Vect4dbl ScaleAsVect(double v, Vect4dblI vector)
		{
			return new Vect4dbl(ScaleAsPoint(v,vector));
		}

		public static planar.Vect4dbl Scale(Vector4dblI vect, double t)
		{
			return Scale(
				geometry.planar.vect._RegressionsX.ToNew(vect),t
			);

			;
		}


		static public planar.vect_.Polar4dbl Scale(this planar.vect_.Polar4dbl vector, double directionOfBoard) {

			return new planar.vect_.Polar4dbl(
				vector.polarPoint.azimuth
				,
				vector.polarPoint.radius*directionOfBoard
			);
		}


	}
}
