using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.angle.be_
{
	/// <summary>
	/// two points can be connected by a path internally, except endpoints.
	/// </summary>
	public  class Convex
	{
		static public bool _Be_assumeNonegLtTau(double radian) {
			return radian > 0 && radian < Math.PI ;
		}
	}
}
