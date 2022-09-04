using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation.convert_
{
	/// <summary>
	/// Supplementary angles are two angles whose sum is 180 degrees while complementary angles are two angles whose sum is 90 degrees. Supplementary and complementary angles do not have to be adjacent (sharing a vertex and side, or next to), but they can be.
	/// </summary>
	/// 补角
	static public class _SupplementX
	{
		static public double Double(double rotation) {
			return rotation_._StraightX.DOUBLE - rotation;
		}
	}
}
