using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.unital
{
	static public class _RotorX
	{
		/// <summary>
		/// project the point along the normal, then we subtract the double of that.
		/// </summary>
		/// <param name="_rotor_assumeUnital"></param>
		/// <param name="point2reflectAroundTheLineDeterminedByRotorAsNorm"></param>
		/// <returns></returns>
		static public geometry.planar.Vect4dbl _Reflect_rotorAssumeUnital(
			planar.Vect4dblI _rotor_assumeUnital
			,
			planar.Vect4dblI point2reflectAroundTheLineDeterminedByRotorAsNorm
		) {
			return point2reflectAroundTheLineDeterminedByRotorAsNorm.point - 2 *   vect.
		}
	}
}
