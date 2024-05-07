using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.grad_.skid_
{
	/// <summary>
	/// favored in topology, as in this case, the neighborhood of any point is inside the entity, making it easy and strict to define.
	/// </summary>
	/// <remarks>
	/// this is theoretically favored in that it's easy to define. And then it can be combined with end points, to extend for a new definition.
	/// </remarks>
	internal class IOpen:ISkid
	{
	}

	/// <summary>
	/// This is not favored in comparison with the other 3 cases:
	///		<see cref="IOpen"/>
	///		,<see cref="IClopen"/>
	///		,<see cref="IClosed"/>
	/// </summary>
	/// alias:
	///		openClose, an akward name, indicating it's not a good choice for use.
	interface IOpenClose { }

}
