using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line.vsPoint
{
	/// <summary>
	/// 
	/// </summary>
	/// alias: pedal
	///		foot
	///			,might be confused with the unit <see cref="geometry.linear_._measured.unit_.eng_.Foot"/>
	///
	static public class _PedalX
	{

	}
	static public class _Foot4perpendX
	{
		static public planar.Point4dbl Foot4perpend(
			planar.grad_.Skid4dblI line
			,
			planar.Point4dblI point
		) {

			return nilnul.geometry.planar.vect.op_.binary_._MinusX.Point(
				point
				,
				_LegX.Foot2point(
					point,line
				)
			);


		}

		static public planar.Point4dbl Foot4perpend(
			planar.LineDbl line
			,
			planar.Point4dblI point
		) {

			return nilnul.geometry.planar.vect.op_.binary_._MinusX.Point(
				point
				,
				_LegX.Foot2point(
					point,line
				)
			);

		}

	}
}
