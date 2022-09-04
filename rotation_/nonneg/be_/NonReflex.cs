using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.angle.simple.be
{
	public partial class NonReflex
	{
		static public bool Eval(double radian) {
			return radian<= Math.PI;
		}
	}
}
