using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.splash_
{
	/// <summary>
	/// for any two points, there is a road (a line of positive width)
	/// </summary>
	public interface IRoadable : ISplash, sub_.connected_.IRoadable, flank_.IBroadable
	{
	}
}
