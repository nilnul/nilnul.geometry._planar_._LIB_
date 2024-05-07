using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// eg:
	///		x is in (0,1]
	/// </summary>
	/// alias:
	///		swath
	///			,like swarm, hence no hole;
	///		stretch
	///		
	public interface ISwath
		:
		surface_.ISimple
		///, ITope
	{
	}
}