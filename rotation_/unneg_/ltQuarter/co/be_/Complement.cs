using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.angle.simple.be.acute.op
{
	static public partial class Complement
	{
		static public bool Eval(double angle,double angle1) {
			return  angle+ angle1 == RadianX.Rigth;
		}
	}
}
