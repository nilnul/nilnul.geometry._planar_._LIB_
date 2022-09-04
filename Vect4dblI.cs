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



namespace nilnul.geometry.planar
{
	/// <summary>
	/// a semantic box of point:
	///		vector is a point with a translated origin, where the origin is variable.
	/// </summary>
	public interface Vect4dblI
	{
		planar.Point4dblI point { get; }
	}


}
