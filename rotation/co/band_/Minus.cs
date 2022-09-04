using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation.co.band_
{
	static public class _MinusX
	{
		static public Rotation1 Minus(Rotation1 a, Rotation1 b) {
			return new Rotation1(
				a.quantity-b.quantity
			);
		}

		static public Rotation1 Minus(RotationI1 a, RotationI1 b) {
			return Minus( new Rotation1(a) , new Rotation1(b));
		}
	}
}
