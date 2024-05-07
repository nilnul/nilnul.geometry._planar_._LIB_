using nilnul.geometry.planar.cycle_.gon_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.ray_.horizon_.decrease.vsGrad
{
	/// <summary>
	/// the intersection can be none, 1, or many points among which the nearest is selected;
	/// </summary>
	static public class _NearestJoint
	{

	/// <summary>
	/// the intersection can result:
	///		no point
	///		one point
	///		or many points among which the nearest is selected.
	/// </summary>
		public static double? NearestJoint(
			this Point4dblI rayBase
			,
			planar.Grad4dbl_byPointsI grad
		)
		{

			/// to maximize the throughtput of existing code (<see cref="nilnul.dev.src."/>), let's do this by morph;
			///
			/// let's do a vwer morph (global morph of axis,while entities remain unmorphed)
			/// 
			/// to make the ray increase, we need to flip the real axis
			///
			/// 
			///

			var t = increase.vsGrad._NearestJoint.NearestJoint(
				morph_.rebase_.orient_.flip_._RealX.Point(
					rayBase
				)
				,
				morph_.rebase_.orient_.flip_._RealX.Grad(grad)
			);

			return morph_.rebase_.orient_.flip_._RealX.Real0nul(
					t
				);


			

		}

	}
}
