using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.point
{
	static public class CoX
	{
		static public double Integral(this CoD duo)
		{

			//trapoid
			return (duo.component1.x - duo.component.x) * (duo.component1.y + duo.component.y) / 2;

			throw new NotImplementedException();

		}

		static public double Distance(this CoD duo)
		{
			var xShift = duo.component1.x - duo.component.x;
			var yShift =duo.component1.y - duo.component.y;
			return Math.Sqrt(
				xShift * xShift
				+ yShift * yShift


			);
		}




	}
}
