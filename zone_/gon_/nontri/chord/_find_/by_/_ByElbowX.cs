using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_.nontri.chord._find_.by_
{
	static public class _ByElbowX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="vertices">
		///		distinct
		///		each corner is not align
		///		forms a zone
		///		four or more edges
		///			
		/// </param>
		/// <returns>
		/// the convex corner is found in (0,count-1) an open interval; that is: it's neither first nor last.
		/// the chord is either the cathetus, or one that starts from the corner and ends at a point that is not adajcent.
		/// </returns>
		static public (Complex start, Complex end) _FindChord_0nontriZone(
			IEnumerable<Complex> vertices
		)
		{
			///find first convex corner:
			var count = vertices.Count();



			int i = 0;

			int pivotIndex;

			int elbowStopIndex;


			Complex start;
			Complex pivot;
			Complex stop;

			do
			{
				//var iBase = i;
				start = vertices.ElementAt(i);

				pivotIndex = (++i == count ? 0 : i);// % count;

				pivot = vertices.ElementAt(pivotIndex);

				elbowStopIndex = (++pivotIndex == count ? 0 : pivotIndex);// % count;

				stop = vertices.ElementAt(elbowStopIndex);



			} while (
					geometry.planar.curl_.elbow.be_._NonProwindX._Be_ofElbow(
						 start, pivot, stop
					)
			);

			/// <see cref="corner_.convex_.inner._ChordX"/>
			/// note, other vertices might be not in the angle. So simply get the point furtherest from the subtend <see cref="planar.angle.ISubtend"/> (closer to the corner) would not work out.
			///

			/// whether all other vertices are outside the trigon?
			///
			/// get all the vertices inside the trigon:
			///

			///corner

			///convex elbow; corner start
			var trigon = (
				start
				,
				pivot
				,
				stop
			);

			IEnumerable<int> nontrigonCongruents = Enumerable.Range(elbowStopIndex + 1, count - 3);

			//var otherVertices = nontrigonCongruents.Select(i => i % count).Select(
			//	x=> vertices.ElementAt(x)
			//);

			var subtended = nontrigonCongruents.Select(i => vertices.ElementAt(i % count)).Where(
				w =>
				{
					return nilnul.geometry.planar.curl_.elbow_.pro.vsPoint.be_._subtend_.by_._ByCrossProductX._Has_0elbowPro(
						trigon
						,
						w
					);
				}
			).ToArray();

			if (subtended.Any())
			{
				//var subtend = (start, stop);

				return (
					pivot,
					nilnul.obj.str_.started.to_.scala_.min_._MappedX.Min_assumeStarted(
						subtended
						,
						i => nilnul.geometry.planar.cloze_.trigon.parlgrm._SurroundedX._Surround(
							start
							, stop
							,
							i

						)
					)
				);


			}
			else
			{
				return (start, stop);
			}

		}
	}
}
