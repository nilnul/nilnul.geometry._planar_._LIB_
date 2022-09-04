using nilnul.geometry.planar.grad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line0point.vsPoint
{
	/// <summary>
	///  compute the perpendicular leg(the point to the perpendicular foot)
	///  if the line0point is a point, the leg is between the two points.
	/// </summary>
	/// alias:
	/// 
	static public class _LegX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="apex">
		/// a point
		/// </param>
		/// <param name="line0point"></param>
		/// <returns></returns>
		static public planar.Vect4dblI Foot2point(
			planar.Point4dblI apex,
			planar.Tend4dblI line0point

		) {
			var fromHinge2Point = nilnul.geometry.planar.vect.op_.binary_._MinusX.Op(
				apex
				,
				line0point.points.component
			);
			if (geometry.planar.tend.be_.NilDbl.Singleton.be(line0point))
			{
				return fromHinge2Point;
			}


			var fromFootToPoint= vect.to_.co_.decompose._RejectionX.Rejection1(
				fromHinge2Point,
				nilnul.geometry.planar.tend._AlignmentX.GtNegPiLePi(line0point)

			);

			return  fromFootToPoint;
		}


	
	}
}
