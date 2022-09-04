using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.lead.vsPoint
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
		/// <param name="point">
		/// a point
		/// </param>
		/// <param name="lead">stands for a lead<see cref="geometry.planar.ILead"/>(directed line), which happens to pass thru origin.</param>
		/// <returns></returns>
		static public planar.vect_.Polar4dbl_radius1st Foot2point(
			planar.Point4dblI point
			,
			planar.Lead4dbl lead
		) {
			var fromHinge2Point = nilnul.geometry.planar.vect.op_.binary_._MinusX.Op(
				point
				,
				lead.arrow.begin
			);


			var fromFootToPoint= vect.to_.co_.decompose._RejectionX.Rejection1(fromHinge2Point, lead.arrow.direction);

			return  fromFootToPoint;
		}

	}
}
