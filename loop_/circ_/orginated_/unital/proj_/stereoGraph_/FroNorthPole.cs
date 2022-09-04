using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.loop_.circ_.orginated_.unital.proj_
{
	/// <summary>
	/// from (0,1)
	/// </summary>
	public class FroNorthPole
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="z"></param>
		/// <returns>
		/// for north pole, the returned infinity is not done here.
		/// </returns>
		static public double Map_assumeOnCircleExcludingNorthPole(
			double x, double z
		) {
			return x / (1 - z);
		}

		static public (double,double) Src(
			double u
		) {
			var sq = u * u;
			var sqInc = sq + 1;
			return (
				2*u / sqInc
				,
				sq-1/sqInc
			);
		}

	}
}
