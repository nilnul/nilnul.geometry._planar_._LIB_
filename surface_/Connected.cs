using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.surface_
{
	public interface IConnected
		:ISurface
		,
		sub_.IConnected
		//,
		//sub_.connected_.IRoadable
	///this implies <see cref="sub_.connected_.IRoadable"/>, as the intersected point is also a surface.
	{
	}
}
