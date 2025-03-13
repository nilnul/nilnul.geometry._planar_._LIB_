using nilnul.geometry.planar.curve_.elliptic_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.ellipse
{
	internal class _ArcX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="ellipse"></param>
		/// <param name="startAngle">
		///If one thinks of an ellipse as a circle that has been stretched and then rotated,then this angle is of the arc prior to the stretch and rotate operations. 
		/// </param>
		/// <param name="sweep">
		///If one thinks of an ellipse as a circle that has been stretched and then rotated,then this angle is of the arc prior to the stretch and rotate operations. 
		///
		/// </param>
		/// <returns></returns>
		(System.Numerics.Complex start, bool large, bool orient, System.Numerics.Complex end) Centered2pegged(
			cloze_.Ellipse ellipse, double startAngle, double sweep
		) {

			var start = ellipse.locus(startAngle);
			var end = ellipse.locus(startAngle+sweep);

			var large = Math.Abs( sweep ) > Math.PI;
			var orient = sweep > 0;

			return (start, large, orient,end);
		}

		(C center, double startAngle, double sweep) pegged2centered(
			Arc8dbl arc
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



			var shifter = nilnul.num.complex.of_.binary_._AverageX.Average(start8scaled, end8scaled);

			var start8shifted = start8scaled - shifter;

			var end8shifted = -start8shifted; // end8scaled - shifter;


			var halfChord8shifted = start8shifted.Magnitude;



			var center8shifted = start8shifted
				*
				(arc.sweep == arc.large
				? -1:1)
				*
				C.ImaginaryOne
				*
				Math.Sqrt(
					1-
					nilnul.num.real.op_.Square.Singleton.op(halfChord8shifted)
				) / halfChord8shifted
			;

			double startPhase8shift = (start8shifted - center8shifted).Phase;

			var startAngle = startPhase8shift + arc.rotation ;

			var sweepAngle =   (end8shifted - center8shifted).Phase - startPhase8shift;

			if (arc.sweep)
			{
				if (sweepAngle<0)
				{
					sweepAngle += nilnul.num.real_.eg_._Tau4dblX.FULL;
				}
				else
				{

				}
			}
			else
			{
				if (sweepAngle>0)
				{
					sweepAngle -= nilnul.num.real_.eg_._Tau4dblX.FULL;
				}
				else
				{

				}

			}
		

			var center = nilnul.num.complex.of_.binary_._ScaleX.Scale(
				(center8shifted + shifter)
				,
				new C(arc.majorAsDbl,arc.minorAsDbl)
			)* rotaterConjugate;


			return (center, startAngle, sweep: sweepAngle );



		}


	}
}
