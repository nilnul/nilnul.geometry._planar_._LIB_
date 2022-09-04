using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.geometry.planar.point.str_;
//using nilnul.geometry.planar.point.str_.started;
using nilnul.geometry.planar.sub_.directed_.connected_.gon;
using nilnul.obj.str.be_;

namespace nilnul.geometry.planar.grad_.skid.str.be_
{
	/// <summary>
	/// no edges crossing each other; crossing means the intersected point is in the middle of some edge, that means, adjacency (share same endpoint), is not crossing.
	/// </summary>
	static public class _JointOne4DblX
	{
		/// <summary>
		/// </summary>
		/// <param name="arrows"></param>
		/// <param name="arrow"></param>
		/// <returns></returns>
		/// in polygon, we need a helper to determine whether one grad is joint with other nonadjacent grads
		/// 
		static public bool _JointAny(
			IEnumerable<grad_.Skid4dblI> arrows
			,
			grad_.Skid4dblI arrow)
		{
			return arrows.Any(
				x =>
				nilnul.geometry.planar.grad_.skid.re_.Joint4dbl.Singleton.re(x, arrow)

			);
		}

		/// <summary>
		/// a helper to determine whether one grad is joint with other grads that is nonadjacent.
		/// </summary>
		static public bool _JointNone(
			IEnumerable<grad_.Skid4dblI> arrows
			,
			grad_.Skid4dblI arrow
		)
		{
			return nilnul.obj.str.be_._NoneX.None(
				arrows,

				x => nilnul.geometry.planar.grad_.skid.re_.Joint4dbl.Singleton.re(x, arrow)

			);
		}
	}
}