using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.grad.str_.seq
{
	/// <summary>
	/// a str of arrows.
	/// </summary>
	static public  class _SurroundedX
	{
		static public nilnul.num.RealI Stokes(IEnumerable<planar.GradI> arrows) {
			return nilnul.num.real.str._SumX.Sum_bisect( arrows.Select(x =>
				planar.grad._StokesX.Stokes(x)
			));
		}
	}
}
