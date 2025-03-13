using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil.rotation_
{
	static public class _FroPointF
	{
		static public float ToLtTau(PointF point ) {

			var atan= Math.Atan2(point.Y,point.X);
			if (atan<0)
			{
				atan += (2*Math.PI);


			}
			return (float)atan;

		}

	}
}
