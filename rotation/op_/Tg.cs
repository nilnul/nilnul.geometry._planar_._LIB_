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
	static public class _TgX
	{
		static public double Double(double radian) {
			return  Math.Tan(radian);
		}
		static public double OfDeg(double deg) {
			return Double(
				nilnul.geometry.planar.rotation_.Degree.ToRadian(deg)
			);
		}



	}
	
}
