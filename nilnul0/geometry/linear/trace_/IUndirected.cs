using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.trace_
{
	/// <summary>
	/// the point is linear ordered according to the position.
	/// </summary>
	/// alias:
	///		sorted
	///		ordered
	///		directed
	///		oriented
	///		sequential
	/// <seealso cref=""/>
	/// vs undirected
	///		directed is the default for 1d shape.
	public interface IUndirected :  ITrace
	{
	}
}
