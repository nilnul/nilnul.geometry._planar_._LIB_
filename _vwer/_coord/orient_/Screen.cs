using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._vw._coord.orient_
{
	/// <summary>
	/// x:
	///		from left to right
	/// </summary>
	/// 	 <see cref="nameof(geometry.planar_.ergo_.canvas_.IScreen)"/>
	///		in old days, we use book. in these days, we use screen. 
	///			see planar_.Book, which goes from left to right, top to down.
	///				same goes Screen.

	public interface IScreen
		:IOrient
	{
	}
}
