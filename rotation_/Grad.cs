using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation_
{
	/// <summary>
	///  the arcTg (x). from (-Tau/4, Tau/4)
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	static public class _GradX
	{
		static public double Rotation_gtQuarterLtQuarter(double height) {
			return Math.Atan(height);
		}
	}
}
