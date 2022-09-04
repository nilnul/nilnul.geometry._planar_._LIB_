using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_
{
	/// <summary>
	/// how to construct 2d objects from 1d.
	/// </summary>
	enum Construct_
	{
		/// <summary>
		/// like <see cref="nilnul.geometry.linear.curve_._byConstruct.Cut"/>,  we can construct 2d cloze curve by cloze a 1d (in fractal dimension ) curve before acquiring an inner zone.
		/// </summary>
		/// eg:
		///		circle
		///		cycle
		Cloze
			,
		/// <summary>
		/// perspect can be regarded as a special <see cref="Cloze"/>:
		///
		///		moving along the basis from left to right, then along the affine edge to right end of the top edge/point, then along the top curve from right to left, then from the left end of the top curve downward to the left end of the basis
		/// </summary>
		Perspect
	


	}
}
