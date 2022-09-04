using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry._2d.angle.duo.be
{
	public partial class Coterminal
	{
		static public bool Eval(double radian, double radian1) {
			return nilnul.num.real.be.Whole.Eval( (radian -radian1) /RadianX.Tau);
		}


	}
}
