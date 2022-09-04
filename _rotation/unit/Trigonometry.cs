using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.plane
{
	public class Trigonometry
	{
		static public double Degree2Radian(double degree) {
			return degree / 180 * Math.PI;
		}
		static public double Radian2Degree(double radian) {
			return radian /  Math.PI * 180;
		}
	}
}
