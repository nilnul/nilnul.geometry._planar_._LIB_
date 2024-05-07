using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.angle.be_
{
	public  class Simple
	{
		static public bool Eval(double radian) {
			return radian >= 0 && radian < Math.PI * 2;
		}
	}
}
