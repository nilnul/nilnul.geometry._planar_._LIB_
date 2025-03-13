using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._troll_.fn_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		scope
	///		bound
	///		confined
	///		

	interface IBonded : IFn
	{
	}
	interface BondedI : IBonded, Fn4dblI
	{
		/// <summary>
		/// for any time in the <see cref="interval"/>, return a point.
		/// </summary>
		/// <remarks>
		/// can also be understood as clipping part of a long curve;
		/// </remarks>
		nilnul.num.real.Interval4dbl interval { get; }


	}

}
