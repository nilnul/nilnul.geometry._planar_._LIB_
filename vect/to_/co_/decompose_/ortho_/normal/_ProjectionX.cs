using nilnul.geometry.planar.point_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.to_.co_.decompose
{
	/// <summary>
	/// the decomposed of, say a force (the vector), along the given <see cref="planar.ILeadDbl"/> as a basis/axis. or the coord at the given axis, which passes thru the old origin. (this is <see cref="nilnul.geometry.planar.trans_.rebase_.IShearOnly"/> of the axis)
	/// </summary>
	/// <remarks>
	///	the decomposed component of the primary axis is called projection
	/// </remarks>
	/// alias:
	///		shadow
	///			as sunshine parrallelly projected all over the board into one direction defined by a lead, the shadow on a board which is perpendicular to the sunshine. Also, the board is directed, and is rotated +90 with respect to the lead.
	///		perspect
	///		precept
	///		projection
	///		
	///
	/// 
	static public class _ProjectionX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="vector"></param>
		/// <param name="directionOfPrimaryAxis">a rotation. (a lead thru the origin)</param>
		/// <returns></returns>
		static public double ScalarProject(
			planar.vect_.Polar4dbl vector
			,
			double directionOfPrimaryAxis
		) {
			return  vector.polarPoint.radius
				*
				Math.Cos(
					vector.polarPoint.azimuth-

					directionOfPrimaryAxis
				);
		}
		static public double ScalarProject(
			planar.vect_.Polar4dbl_radius1st vector
			,
			double directionOfPrimaryAxis
		) {
			return  vector.polarPoint.radius
				*
				Math.Cos(
					vector.polarPoint.azimuth-

					directionOfPrimaryAxis
				);
		}



		static public double ScalarProject(planar.Vector4dblI vector, double directionOfPrimaryAxis) {



			return  ScalarProject( planar.vect_.Polar4dbl.Of(vector) , directionOfPrimaryAxis) ;
		}

		static public double ScalarProject(planar.Vect4dblI vector, double directionOfPrimaryAxis) {



			return  ScalarProject( planar.vect_.Polar4dbl_radius1st.Of(vector) , directionOfPrimaryAxis) ;
		}

		public static double ScalarProject(Polar4dbl point, double azimuth)
		{
			return ScalarProject(new vect_.Polar4dbl(point),azimuth);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="vector"></param>
		/// <param name="directionOfPrimaryAxis"></param>
		/// <returns></returns>
		static public planar.vect_.Polar4dbl Project(
			planar.Vector4dblI vector
			,
			double directionOfPrimaryAxis
		) {

			return new planar.vect_.Polar4dbl(
				directionOfPrimaryAxis,
				ScalarProject(vector,directionOfPrimaryAxis)
			);
			// if the radius is neg, then the normalized azimuth would be opposite to the unnormarlized. And the result is correct.
		}

		static public planar.vect_.Polar4dbl_radius1st Project(
			planar.Vect4dblI vector
			,
			double directionOfPrimaryAxis
		) {

			return new planar.vect_.Polar4dbl_radius1st(
				ScalarProject(vector,directionOfPrimaryAxis)
				,
				directionOfPrimaryAxis
			);
			// if the radius is neg, then the normalized azimuth would be opposite to the unnormarlized. And the result is correct.
		}


		

	}
}
