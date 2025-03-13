using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation_.nonneg_
{
	/// <summary>
	/// also know as: orientation,  align
	/// </summary>
	static public class _LtPi4DblX
		
	{
		static public double Normalize(double rotation) {
			var t = rotation % Math.PI ;
			if (t<0)
			{
				return t + Math.PI;
			}
			return t;
		}
	}
}
