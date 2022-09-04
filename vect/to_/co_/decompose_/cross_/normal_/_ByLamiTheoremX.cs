using nilnul.geometry.planar.point.as_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.to_.co_.decompose_.cross_.normal_
{
	/// <summary>
	/// decompose into two normal vector
	/// </summary>
	static public class _ByLamiTheoremX
	{
		static public double[] Decompose_assumeBasisCross(
			planar.vect_.Polar4dbl_radius1st vect
			,
			double basis1stAngle
			,
			double secondBasisAngle
		) {


			var normOverSin = vect.polarPoint.radius / Math.Sin(secondBasisAngle - basis1stAngle);

			return new double[] {
				normOverSin * Math.Sin(secondBasisAngle-vect.polarPoint.azimuth)
				,
				normOverSin * Math.Sin( vect.polarPoint.azimuth -basis1stAngle )
			};

			
		}

	}
}
