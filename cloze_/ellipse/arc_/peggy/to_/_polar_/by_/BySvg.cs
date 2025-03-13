using nilnul.geometry.planar.curve_.elliptic_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.ellipse.arc_.peggy.to_
{
	internal class MorphedCircle
	{
		void pegged2centered(
	Arc8dbl arc
)
		{
			///w3.org/TR/SVG/implnote.html#Introduction
			///
			/// The equations simplify after a translation which places the origin at the midpoint of the line joining (x1, y1) to (x2, y2), followed by a rotation to line up the coordinate axes with the axes of the ellipse.
			///
			///

			/// displace to:
			///


			var rotater = Complex.FromPolarCoordinates(1, -arc.rotation);

			var rotaterConjugate = Complex.Conjugate(rotater);


			var start8rotated = (arc.start8complex) * rotater;
			var end8rotated = (arc.end8complex) * rotater;


			var start8scaled = new C(
				start8rotated.Real / arc.majorAsDbl
				,
				start8rotated.Imaginary / arc.minorAsDbl
			);

			var end8scaled = new C(
				end8rotated.Real / arc.majorAsDbl
				,
				end8rotated.Imaginary / arc.minorAsDbl
			);

			var shifter = nilnul.num.complex.of_.binary_._AverageX.Average(start8scaled, end8scaled);

			var start8shifted = start8scaled - shifter;

			var end8shifted = -start8shifted; // end8scaled - shifter;


			var halfChord8shifted = start8shifted.Magnitude;



			var center8shifted = start8shifted * C.ImaginaryOne
				*
				Math.Sqrt(
					1 -
					nilnul.num.real.op_.Square.Singleton.op(halfChord8shifted)
				) / halfChord8shifted
			;

			double startPhase8shift = (start8shifted - center8shifted).Phase;

			var startAngle = startPhase8shift + arc.rotation;

			var sweepAngle = (end8scaled - center8shifted).Phase - startPhase8shift;

			var center = nilnul.num.complex.of_.binary_._ScaleX.Scale(
				(center8shifted + shifter)
				,
				new C(arc.majorAsDbl, arc.minorAsDbl)
			) * rotaterConjugate;




			var newOrigin = (
						(arc.start8complex + arc.end8complex) / 2

					);

			var start8morph = (arc.start8complex - newOrigin) * rotaterConjugate;



			double majorSq = nilnul.num.real.op_.Square.Singleton.op(
								arc.majorAsDbl
							);
			double minorSq = nilnul.num.real.op_.Square.Singleton.op(
								arc.minorAsDbl
							);


			double major_newY1 = arc.majorAsDbl * start8morph.Imaginary;
			double minor_newX1 = arc.minorAsDbl * start8morph.Real;

			double majorSq_newYSq = majorSq * nilnul.num.real.op_.Square.Singleton.op(start8morph.Imaginary);

			double majorNewY1_Sq = nilnul.num.real.op_.Square.Singleton.op(major_newY1);

			double minorSq_newXSq = minorSq * nilnul.num.real.op_.Square.Singleton.op(start8morph.Real);

			double minorNewX1_Sq = nilnul.num.real.op_.Square.Singleton.op(minor_newX1);

			double denom = majorSq_newYSq + minorSq_newXSq;


			var center8morphed = (arc.large == arc.sweep ? -1 : 1) * Math.Sqrt(
				(
				majorSq
				*
				minorSq
				- denom
				)
				/

					denom


			) * new Complex(
				 major_newY1 / arc.minorAsDbl
				 ,
				 minor_newX1 / arc.majorAsDbl
				)
				;

			var center = center8morphed * rotater + newOrigin;

			Complex startStreched8morph = new Complex(
							(start8morph.Real - center8morphed.Real) / arc.majorAsDbl,

							(start8morph.Imaginary - center8morphed.Imaginary) / arc.minorAsDbl
						);


			var startAngle = startStreched8morph.Phase;

			var sweep = nilnul.num.complex.of_.binary_.delta_._ConjugateMultiX.ConjugateMulti(
				startStreched8morph
				,
new Complex(
							(-start8morph.Real - center8morphed.Real) / arc.majorAsDbl,

							(-start8morph.Imaginary - center8morphed.Imaginary) / arc.minorAsDbl
						)
			).Phase;

			var sweepAsDirection = planar.rotation_.DirectionDbl.Create_byCannonize(sweep);

			if (arc.sweep)
			{

			}




		}



	}
}
