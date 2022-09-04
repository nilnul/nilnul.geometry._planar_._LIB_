using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_
{
	/// <summary>
	/// F(x,y)=0 is a polynomial in two variables: x , y.
	/// </summary>
	/// <remarks>
	/// this is planar curve, not a function. So x, y is in same status. Hence here poly means both x and y.
	/// alias:
	///		Algebraic
	///			we only add and multi.
	///				in abstract algebra, such as ring, the two ops are add and multi
	///		Polynomial
	///			dont use this as : (1) confusing with polyline. (2) 0-order polynomial trail is not well defined.
	/// </remarks>
	public interface IAlgebraic
	{
	}
}
