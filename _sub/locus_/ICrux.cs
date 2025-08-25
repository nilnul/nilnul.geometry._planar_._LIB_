using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._sub.locus_
{
	/// <summary>
	/// to take on the common definition of a curve, here the continuous means for a <see cref="nilnul.num.real.borel_ .IContiguous"/> which can be closed (even a single point <see cref="troll_.IPointal"/>), open or halfOpen. 
	/// for a closed interval [a,b], (-inf, a ) -> l(a) that is the point is at the start before the interval. (b, +inf) -> l(b), that is the locus will remain at the finale after the interval.
	/// for open border, like in (a, b], l(a) might be infinite
	/// </summary>
	/// alias:
	///		crux
	///			,curx
	///	<see cref="planar.ITroll"/>
    public interface ICrux:locus_.conn_.IDwelt
    {
    }
}
