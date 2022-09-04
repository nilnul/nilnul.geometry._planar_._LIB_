using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraic_
{
	/// <summary>
	/// not a general algebraic like xy=1, but a polynomial one, in which only one variable is in algebraic form, and the other one is a dependent.
	/// </summary>
	/// <remarks>
	/// this is planar curve, not a function. So x, y is in same status. Hence here poly means both x and y.
	/// alias:
	///		Algebraic
	///			we only add and multi.
	///				in abstract algebra, such as ring, the two ops are add and multi
	///		Polynomial
	/// </remarks>
	///
	[Obsolete(nameof(IAlgebraic))]///dont confuse this with polygon
	public interface IPolynomial :IAlgebraic
		,
		algebraic_.IQuadratic
	{
	}
}
