using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.ray.co.be_
{

	/// <summary>
	/// direction same or opposite
	/// </summary>
	static public  class _CrossableX
	{
		static public bool Be(RayI dir, RayI end) {
			return planar.line.co.be_.Fork.Singleton.re(
				new planar.Line(dir)
				,
				new planar.Line(end)
			);
		}
	

		
		
	}
}
