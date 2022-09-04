using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tope_.gon_.quod_.circum.area_
{
	class ByBrahmagupta
	{
		static public double _Area_lengthsAssumeCircum(double a, double b, double c, double d) {
			var s= (a+b+c+d)/ 2; //semiperi
			return Math.Sqrt(
				(s-a)
				*
				(s-b)
				*
				(s-c)
				*
				(s-d)
			);

		}
	}
}
