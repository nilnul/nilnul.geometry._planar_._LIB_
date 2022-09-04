using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.lead_.originated.vsPoint
{
	/// <summary>
	/// regards the vect as a point, and compute the perpendicular foot
	/// </summary>
	/// alias:
	/// 
	static public class _FootX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="vector">
		/// a point
		/// </param>
		/// <param name="directionOfLead">stands for a lead<see cref="geometry.planar.ILead"/>(directed line), which happens to pass thru origin.</param>
		/// <returns></returns>
		static public planar.Point4dblI Foot(
			planar.Vect4dblI vector
			,
			double directionOfLead
		) {
			return (vector - vect.to_.co_.decompose._RejectionX.Rejection1(vector, directionOfLead) ).point;
		}

		static public planar.Point4dblI Foot(
			planar.Point4dblI vector
			,
			double directionOfLead
		) {
			return Foot( new planar.Vect4dbl(vector), directionOfLead);
		}



	}
}
