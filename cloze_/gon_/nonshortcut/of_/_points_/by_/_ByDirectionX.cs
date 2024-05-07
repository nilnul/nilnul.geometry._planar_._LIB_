using nilnul.num.complex.of_.binary_.add.cumulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using C = System.Numerics.Complex;
using nilnul.num;
using Complex = System.Numerics.Complex;
using nilnul.num.complex;
using nilnul.obj.str.op_;

namespace nilnul.geometry.planar.cloze_.gon_.nonshortcut.of_._points_.by_
{

	static public class _ByDirectionX
	{

		/// <summary>
		/// same points are placed adjacently;
		/// some points of same rotation from the mean would be put on an outgoing line.
		/// </summary>
		/// <param name="points"></param>
		/// <returns></returns>
		static public IEnumerable<Complex> _OfPoints_0dwelt(
				IEnumerable<Complex> points
		) {
			var mean = points._Sum_0finite()/ points.Count();

			//return nilnul.obj.str.op_.sortUnstable_._Quick
			return points._Sort_1comp(
				 comp
			);

			int comp(C a, C b) {
				if (a==mean)
				{
					return -1;
				}
				if (b== mean)
				{
					return 1;
				}

				var aDisplace = a - mean;
				var bDisplace = b - mean;


				var aSwing = (aDisplace).Swing();
				var bSwing = (bDisplace).Swing();

				var swingComped = Comparer<double>.Default.Compare(aSwing,bSwing);

				if (swingComped == 0)
				{
					return aDisplace.Magnitude.CompareTo(bDisplace.Magnitude);
				}
				return swingComped;


			}


		}
	}
}
