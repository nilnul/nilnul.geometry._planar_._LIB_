using nilnul.geometry.planar.point.trio.be_.tripod.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using nilnul.num;

namespace nilnul.geometry.planar.zone_.trigon_
{

	static public class PerpendX 
	{
		static public double Leg_assumeHypotenuse1cathetus(double hypotenus, double cathetus) {
			return Math.Sqrt(
				nilnul.num.real.op_.unary_.Square.Singleton.op(hypotenus)
				-
				nilnul.num.real.op_.unary_.Square.Singleton.op(cathetus)
			);

		}

	}
}
