using nilnul.geometry.planar.curve_.elliptic_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.ellipse.arc_.peggy.to_._polar_.by_
{
	static public  class _ByCircleX
	{

		static public (C center, double startAngle, double sweep) Peggy2polar(
			curve_.elliptic_.Arc8dbl arc
		) {
			
			///math.stackexchange.com/questions/53093/how-to-find-the-center-of-an-ellipse/53163#53163
		

			var rotater = Complex.FromPolarCoordinates(1, -arc.rotation);

			var rotaterConjugate = Complex.Conjugate(rotater);


			var start8rotated = (arc.start8complex ) * rotater;
			var end8rotated = (arc.end8complex ) * rotater;


			var start8scaled = new C(
				start8rotated.Real/ arc.majorAsDbl
				,
				start8rotated.Imaginary/arc.minorAsDbl
			);

			var end8scaled = new C(
				end8rotated.Real/ arc.majorAsDbl
				,
				end8rotated.Imaginary/arc.minorAsDbl
			);

			var t = circ_.unial._ArcX.Peggy2polar(
				
				start8scaled, arc.large,arc.sweep, end8scaled
			);



			var center = nilnul.num.complex.of_.binary_._ScaleX.Scale(
				t.center
				,
				new C(arc.majorAsDbl,arc.minorAsDbl)
			)* rotaterConjugate;


			return (center, t.startAngle, sweep: t.sweep);



		}
		///w3.org/TR/SVG/implnote.html#toc

	/// https://stackoverflow.com/questions/197649/how-to-calculate-center-of-an-ellipse-by-two-points-and-radius-sizes

	}
}
