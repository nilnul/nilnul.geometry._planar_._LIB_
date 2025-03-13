using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.angle.simple.nonReflex
{
	static public partial class Supplement
	{
		static public bool Eval(double angle,double angle1) {
			return angle + angle1 == Math.PI;
		}
	}
}
