using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_._circ
{
	internal class Func
		: nilnul.num.complex.of_.OfDblI
	{
		private nilnul.num.real_.PositiveDbl _radius;

		public nilnul.num.real_.PositiveDbl radius
		{
			get { return _radius; }
			set { _radius = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="par">
		/// time t in [0,tau)
		/// </param>
		/// <returns></returns>
		public Complex op(double par)
		{
			var r = _radius.ee;
			return new Complex( r*Math.Cos(par),r*Math.Sin(par));
		}
	}
}
