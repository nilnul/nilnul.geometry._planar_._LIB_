using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;



namespace nilnul.geometry.planar._ray_
{
	/// <summary>
	/// the starting point, or origin, of the ray
	/// </summary>
	public interface SrcI
	{
		PointI1 src { get; }
	}
}
