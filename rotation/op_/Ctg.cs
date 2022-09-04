using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation
{
	/// <summary>
	/// Cotangent
	/// </summary>
	static public class _CtgX
	{
		static public double Double(double radian) {
			return nilnul.num.real_.nonnil.op_.unary_._InverseX.Op(Math.Tan(radian));
		}

		static public double OfDeg(double deg)
		{
			switch (deg)
			{
				case 45:
					return 1;
				case 30:


				default:
					break;
			}
			

			return Double(
				nilnul.geometry.planar.rotation_.Degree.ToRadian(deg)
			);
		}


	}
	public class Ctg
	{
	}
}
