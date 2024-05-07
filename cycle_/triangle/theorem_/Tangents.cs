using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.trigon.theorem_
{
	/// <summary>
	/// 
	/// </summary>
	static public  class _TangentsX
	{

		static public bool _Pred_0edge_1edge1_2angle_3angle1(
			double edge
			,
			double edge1
			,
			double angle
			,
			double angle1
		) {

			return (edge - edge1) / (edge + edge1) == Math.Tan(
				(angle - angle1) / 2
			) / Math.Tan(
				(angle + angle1) / 2

			);

		}
	}
}
