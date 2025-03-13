using nilnul.geometry.planar.curve_.circ.arc_._peggy_.by_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.circ_.unial
{
	static public  class _ArcX
	{
	


		/// <summary>
		/// the tilt is always nil.
		/// </summary>
		/// <param name="radiusAsDbl"></param>
		/// <param name="start8scaled"></param>
		/// <param name="large"></param>
		/// <param name="sweep"></param>
		/// <param name="end8scaled"></param>
		/// <returns></returns>
		public static (C center, double startAngle, double sweep) Peggy2polar(
			 C start8scaled
			, bool large
			, bool sweep
			, C end8scaled
		)
		{

			///math.stackexchange.com/questions/53093/how-to-find-the-center-of-an-ellipse/53163#53163

			var shifter = nilnul.num.complex.of_.binary_._AverageX.Average(
				start8scaled, end8scaled
			);

			var start8shifted = start8scaled - shifter;

			var end8shifted = -start8shifted; // end8scaled - shifter;


			var halfChord8shifted = start8shifted.Magnitude;

			if (halfChord8shifted == 0)
			{


				if (large)
				{
					if (sweep)
					{
						var center8shifted111 = start8shifted - 1;
						var startAngle =  0;


						return (
							center8shifted111 + shifter
							,
							startAngle
							,
							sweep: nilnul.num.real_.eg_._Tau4dblX.FULL
						);
					}
					else
					{

						var center8shifted111 = start8shifted + 1;
						var startAngle =  Math.PI;

						return (
							center8shifted111 + shifter
							,
							startAngle
							,
							sweep: -nilnul.num.real_.eg_._Tau4dblX.FULL
						);


					}

				}
				else
				{

					if (sweep)
					{
						var center8shifted111 = start8shifted - 1;
						var startAngle =  0;


						return (
							center8shifted111 + shifter
							,
							startAngle
							,
							sweep: 0
						);
					}
					else
					{

						var center8shifted111 = start8shifted + 1;
						var startAngle =  Math.PI;

						return (
							center8shifted111 + shifter
							,
							startAngle
							,
							sweep:0
						);


					}

				}

			}


			var center8shifted = start8shifted
				*
				(sweep == large
				? 1 : -1)
				*
				C.ImaginaryOne
				*
				Math.Sqrt(
					1 -
					nilnul.num.real.op_.Square.Singleton.op(halfChord8shifted)
				) / halfChord8shifted
			;

			double startPhase8shift = (start8shifted - center8shifted).Phase; // vibrate [-pi,pi]



			var sweepAngle = (end8shifted - center8shifted).Phase - startPhase8shift; // [-2pi, 2pi]

			if (sweep)
			{
				if (sweepAngle < 0)
				{
					sweepAngle += nilnul.num.real_.eg_._Tau4dblX.FULL; // [0,2pi]
				}
				else
				{

				}
			}
			else
			{
				if (sweepAngle > 0)
				{
					sweepAngle -= nilnul.num.real_.eg_._Tau4dblX.FULL; //
				}
				else
				{

				}


			}


			var center = center8shifted + shifter;


			return (center, startPhase8shift, sweep: sweepAngle);



		}

	}
}
