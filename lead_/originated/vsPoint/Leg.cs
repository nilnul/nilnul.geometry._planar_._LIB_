using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.lead_.originated.vsPoint
{
	/// <summary>
	/// regards the vect as a point, and compute the perpendicular leg(the point to the perpendicular foot)
	/// </summary>
	/// alias:
	/// 
	static public class _LegX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="vector">
		/// a point
		/// </param>
		/// <param name="directionOfShine">stands for a lead<see cref="geometry.planar.ILead"/>(directed line), which happens to pass thru origin.</param>
		/// <returns></returns>
		static public planar.vect_.Polar4dbl_radius1st FroFootToPoint(
			planar.Vect4dblI vector
			,
			double directionOfShine
		) {
			var fromFootToPoint= vect.to_.co_.decompose._RejectionX.Rejection1(vector, directionOfShine);

			return  fromFootToPoint;
		}

	}
}
