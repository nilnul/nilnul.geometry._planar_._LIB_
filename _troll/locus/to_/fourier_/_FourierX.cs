using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.geometry.planar._troll.locus.to_
{
	static class _FourierX
	{
		/// <summary>
		/// todo: further review and test and demo is needed;
		/// </summary>
		/// <param name="troll"></param>
		/// <param name="n"></param>
		/// <returns></returns>
		static public IEnumerable<Func<double, C>> Amplitude8freqEs(
			Func<double, C> troll
			,
			int n
		)
		{
			/// https://github.com/wangyoutian/nilnul.num.complex._func_.eg_.in5real_.pwc.expan_.fourier.explainedByJs/blob/bak2408031633329972925-werk-clan/fourier-polygon.js
			///
			/// https://github.com/andymac-2/fourier-polygon/blob/master/docs/fourier-polygon.js
			/// , not:
			/// https://github.com/andymac-2/fourier-polygon/blob/master/fourier-polygon.js
			/// ,which is still unchanged.
			/// 
			var displaces = Enumerable.Range(0, n).Select(
				i => troll((double)i / n)
			).ToArray();

			for (int i = 0; i < n; i++)
			{
				var freq = (double)i / n;

				yield return t =>{

					C r = 0;

					for (int k = 0; k < n; k++)
					{
						r += displaces[k] * C.FromPolarCoordinates(
							1
							,
							-2 * Math.PI  * k* freq		/// i / n
						);	/// when i is 0, this is the geometric center,which moves the most slow; This hints that the frequency is ordered from slow to fast, not by radial. (if the radial is long at the ending fast freq, the line would be zigzagging abruptly. while for a smooth line, the most frequent would be of smaller radial)
					}
					return r /n * C.FromPolarCoordinates(
						1,
						2*Math.PI *freq   /// rotation speed
						* t
					);
				};

			}
		}
	}
}
