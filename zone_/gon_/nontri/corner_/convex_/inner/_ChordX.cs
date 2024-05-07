using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_.nontri.corner_.convex_.inner
{
	/// <summary>
	/// given a convex corner, find a chord, which is either the cathetus of the ear whose tip is the corner, or a chord start at the corner
	/// </summary>
	static public class _ChordX
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
		/// <param name="convex">
		/// not 0, or count-1.
		/// </param>
		/// <returns></returns>
		static public (Complex start, Complex end) _Chord_0nontriZone_1innerConvex(
			IEnumerable<Complex> vertices
			,
			int convex
		)
		{
			///find first convex corner:
			var count = vertices.Count();



			/// note, other vertices might be not in the angle. So simply get the point furtherest from the subtend <see cref="planar.angle.ISubtend"/> (closer to the corner) would not work out.
			///

			/// whether all other vertices are outside the trigon?
			///
			/// get all the vertices inside the trigon:
			///

			///corner

			///convex elbow; corner start
			///

			Complex start = vertices.ElementAt(convex - 1 );
			Complex pivot = vertices.ElementAt(convex);
			Complex end = vertices.ElementAt(convex + 1 );

			var trigon = (
				start
				,
				pivot
				,
				end
			);

			IEnumerable<int> nontrigonCongruents = Enumerable.Range(convex + 2, count - 3);


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

				return (
					pivot,
					nilnul.obj.str_.started.to_.scala_.min_._MappedX.Min_assumeStarted(
						subtended
						,
						i => nilnul.geometry.planar.cloze_.trigon.parlgrm._SurroundedX._Surround(
							start
							, end
							,
							i

						)
					)
				);


			}
			else
			{
				return (start, end);
			}

		}

		static public (int start, int end) _Indexes_0nontriZone_1innerConvex(
			IEnumerable<Complex> vertices
			,
			int convex
		)
		{
			///find first convex corner:
			var count = vertices.Count();



			/// note, other vertices might be not in the angle. So simply get the point furtherest from the subtend <see cref="planar.angle.ISubtend"/> (closer to the corner) would not work out.
			///

			/// whether all other vertices are outside the trigon?
			///
			/// get all the vertices inside the trigon:
			///

			///corner

			///convex elbow; corner start
			///

			int startIndex = convex - 1 ;
			int endIndex = (convex + 1) ;

			Complex start = vertices.ElementAt(startIndex);
			Complex pivot = vertices.ElementAt(convex);
			Complex end = vertices.ElementAt(endIndex);

			var trigon = (
				start
				,
				pivot
				,
				end
			);

			IEnumerable<int> nontrigonCongruents = Enumerable.Range(convex + 2, count - 3);


			var subtended = nontrigonCongruents.Where(
				w =>
				{
					return nilnul.geometry.planar.curl_.elbow_.pro.vsPoint.be_._subtend_.by_._ByCrossProductX._Has_0elbowPro(
						trigon
						,
						vertices.ElementAt(w % count)
					);
				}
			).ToArray();

			if (subtended.Any())
			{

				return (
					convex,
					nilnul.obj.str_.started.to_.scala_.min_._MappedX.Min_assumeStarted(
						subtended
						,
						i => nilnul.geometry.planar.cloze_.trigon.parlgrm._SurroundedX._Surround(
							start
							, end
							,
							i

						)
					)
				);


			}
			else
			{
				return (startIndex, endIndex);
			}

		}

	}
}
