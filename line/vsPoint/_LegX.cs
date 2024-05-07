using nilnul.geometry.planar.grad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line.vsPoint
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
			planar.LineDbl lead
		) {
			var fromHinge2Point = nilnul.geometry.planar.vect.op_.binary_._MinusX.Op(
				point
				,
				lead.point
			);


			var fromFootToPoint= vect.to_.co_.decompose._RejectionX.Rejection1(
				fromHinge2Point, lead.alignmentUnnormal
			);

			return  fromFootToPoint;
		}

		public static vect_.Polar4dbl_radius1st Foot2point(Point4dblI point, Skid4dblI line)
		{
			var fromHinge2Point = nilnul.geometry.planar.vect.op_.binary_._MinusX.Op(
				point
				,
				line.basis
			);


			var fromFootToPoint= vect.to_.co_.decompose._RejectionX.Rejection1(
				fromHinge2Point,
				nilnul.geometry.planar.grad_.skid._DirectionX.GtNegPiLePi(line)

				
			);

			return  fromFootToPoint;

		}
	}
}
