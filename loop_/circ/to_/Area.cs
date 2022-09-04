using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.circle.to_
{
	/// <summary>
	/// enclosed area
	/// </summary>
	public class Area
	{
		static public double Eval(double radius) {
			return Math.PI * nilnul.num.real.op_.unary_.Square.Singleton.op(radius);
		}
		static public decimal Eval(decimal radius) {
			return nilnul.num.real_.tau.Pi.asDcimal* nilnul.num.real.op_.unary_.Square.Singleton.op(radius);
		}


	}
}
