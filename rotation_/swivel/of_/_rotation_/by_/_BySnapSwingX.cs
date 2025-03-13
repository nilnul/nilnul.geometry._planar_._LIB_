using System;

namespace nilnul.geometry.planar.rotation_.swivel.of_._rotation_.by_
{
	[Obsolete(nameof(_ByNegSwingX) + " is more continuous, or less snappy;")]
	static public class _BySnapSwingX {
		static public double _Swivel_0rotation(double rotation) {
			var swing = rotation_.swing.of_._rotation_.by_._ByShiftX._Swing_0rotation(rotation);

			if (swing <= -Math.PI)
			{
				return swing + nilnul.num.real_.eg_._Tau4dblX.FULL;
			}
			return swing;


		}
	}

}
