using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.angle.be
{
	public partial class Full
	{
		static public bool Eval(double radian) {
			return radian == Math.PI * 2;
		}
	}
	public partial class Perigon :Full { }
	public partial class Turn :Full { }

}
