using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation.op_
{
	/// <summary>
	/// Cotangent
	/// </summary>
	static public class _SecX
	{
		static public double Double(double radian) {
			return 1/ _CosX.Double(radian);
		}
		static public double OfDeg(double deg) {
			return Double(
				nilnul.geometry.planar.rotation_.Degree.ToRadian(deg)
			);
		}

	}
	
}
