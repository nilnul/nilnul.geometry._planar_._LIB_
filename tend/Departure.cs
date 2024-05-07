using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend
{
	/// <summary>
	/// the distance from origin
	/// </summary>
	internal class _DepartureX
	{
		static public double Departure( planar.Tend4dbl tend){
			if (
				planar.point.EqDbl.Eq(
					tend.component ,tend.component1
				)
			)
			{
				return geometry.planar.point._DeviationX.Deviation(
					tend.component
				);
			}

			return tend_.edge._DepartureX._Departure_01dif(
				tend.component,tend.component1
			);
		}
	}
}
