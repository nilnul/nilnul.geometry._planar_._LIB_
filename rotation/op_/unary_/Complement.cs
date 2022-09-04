using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation.convert_
{
	/// <summary>
	/// Supplementary angles are two angles whose sum is 180 degrees while complementary angles are two angles whose sum is 90 degrees. Supplementary and complementary angles do not have to be adjacent (sharing a vertex and side, or next to), but they can be.
	/// The S in supplementary can be used to form the 8 in 180.
	/// The C in complementary can be used to form the 9 in 90. 
	/// </summary>
	/// 余角
	static public class _ComplementX
	{
		static public double Double(double rotation) {
			return rotation_._RightX.DOUBLE - rotation;
		}
	}
}
