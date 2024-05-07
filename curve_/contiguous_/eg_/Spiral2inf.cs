using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.contiguous_.eg_
{
	public class Spiral2inf
	{
		private int _freq;

		public int freq
		{
			get { return _freq; }
			set {
				if (value<1)
				{
					throw new ArgumentOutOfRangeException("the frequence must be positive");
				}
				_freq = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="i">
		/// eg:14
		/// </param>
		public Spiral2inf(int i)
		{
			this.freq = i;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// the asymptote line is y=x. and the curve would intersect with that line for infinite times
		/// </remarks>
		/// <param name="t">
		/// time.
		/// </param>
		/// <returns>
		/// if time = 0+, then (+inf, freq)
		/// if time=+inf, then (+inf, inf)
		///
		/// </returns>
		public (double x, double y) _point_0positive(double t) {
			return (
				t+Math.Cos(this._freq*t) /t
				,
				t+Math.Sin(this._freq*t) /t
			);
		}
	}
}
