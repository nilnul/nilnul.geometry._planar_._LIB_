using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.angle.be_
{
	/// <summary>
	/// 
	/// </summary>
	/// a angle just extend to far.
	/// alias:
	///		concave
	///		flip
	///		backflip
	public  class Reflex
	{
		static public bool _Be_assumeNonegLtTau(double radian) {
			return radian >  Math.PI ;
		}
	}
}
