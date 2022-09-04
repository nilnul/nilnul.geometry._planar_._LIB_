using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.geometry.planar.trans
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// We sometimes need to generate a uniformly distributed random rotation matrix. It seems intuitively clear in two dimensions that this means the rotation angle is uniformly distributed between 0 and 2π. 
	/// </remarks>
	public partial class RotationMatrix
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="angleCounterClock"></param>
		/// <returns></returns>
		/// <remarks>
		/// The inverse of a rotation matrix is its transpose, which is also a rotation matrix:
		/// </remarks>
		static public double[,] CreateFroAngle(double angleCounterClock) {


			var cos = Math.Cos(angleCounterClock);
			var sin=Math.Sin(angleCounterClock);
			///(x,y)=(r*cos(a), r*sin(a))
			/// (x`,y`)=( r*cos(a+t), r*sin(a+t) ) = r*cos(a) cos(t) - r*sin(a) sin(t), r*sin(a)*cos(t)+r*cos(a)*sin(t)  = r*cos(a) cos(t) - r*sin(a) sin(t), r*cos(a)*sin(t) +r*sin(a)*cos(t)
			return new double[2, 2] {
				{cos, -sin }
				,
				{ sin, cos}
			};

			/*Note that the two-dimensional case is the only non-trivial (i.e. not 1-dimensional) case where the rotation matrices group is commutative, so that it does not matter in which order multiple rotations are performed. An alternative convention uses rotating axes,[1] and the above matrices also represent a rotation of the axes clockwise through an angle θ.*/
		}
	}
}


