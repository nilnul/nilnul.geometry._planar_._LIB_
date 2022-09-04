using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.angle.op
{
	static public partial class Explement
	{
		static public bool Eval(double angle,double angle1) {
			return angle+angle1==RadianX.Tau;
		}
	}
}
