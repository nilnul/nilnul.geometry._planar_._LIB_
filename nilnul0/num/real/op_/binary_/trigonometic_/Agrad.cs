using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.op_.binary_.trigonometic_
{
	/// <summary>
	/// argument of (<see cref="geometry.planar.rotation_._GradX"/>). when both are nils, return 0.
	/// </summary>
	static class _AgradX
	{
		static public R ArgGradient(Real basis, Real height) {
			if (basis == 0)
			{
				if (height==0)
				{
					return (Real)0;
				}
				else
				{
					if (height>0)
					{
					return nilnul.num.real_.TauX.Quarter;

					}

					return -nilnul.num.real_.TauX.Quarter;
				}
			}
			return nilnul.num.real.op_.unary_.arctg_.BySeries.Singleton.op(height/basis);
		}
		static public R ArgGradient(R basis, R height) {
			return ArgGradient(
				basis.ToReal()
				,
				height.ToReal()
			);
		}

	}
}
