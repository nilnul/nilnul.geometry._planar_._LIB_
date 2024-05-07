using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.spread_
{
	/// <summary>
	/// for any two points, there is a road (a line of positive width)
	/// </summary>
	public interface IRoadable : ISpread, sub_.connected_.IRoadable, flank_.IBroadable
	{
	}
}
