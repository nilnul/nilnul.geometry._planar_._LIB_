using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.plane
{
	static public class Extension
	{
		static public double Radian2Degree(this double radian) {
			return Trigonometry.Radian2Degree(radian);
		}

		static public double Degree2Radian(this double degree) {
			return Trigonometry.Degree2Radian(degree);
		}
	}
}
