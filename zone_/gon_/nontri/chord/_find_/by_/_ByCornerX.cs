using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_.nontri.chord._find_.by_
{
	/// <summary>
	/// start from the first corner. This is fit for a random accessed str such as array or list
	/// </summary>
	///
	[Obsolete()]	
	static public class _ByCornerX
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
		/// <returns></returns>
		static public (Complex start, Complex end) _FindChord_0nontriZone(
			IEnumerable<Complex> vertices
		)
		{
			///find first convex corner:
			var count = vertices.Count();

			int i = 0;

			///find first convex corner
			for (; i < count; i++)
			{

				Complex pivot = vertices.ElementAt(i);
				if (
					geometry.planar.vect_.nonnil.co.be_.Prowind.Singleton.be(
						pivot -
						vertices.ElementAt((i + count - 1) % count)
						,
						vertices.ElementAt((i +  1) % count)-pivot

					)
				)
				{
					break;
				}
			}

			/// note, other vertices might be not in the angle. So simply get the point furtherest from the subtend <see cref="planar.angle.ISubtend"/> (closer to the corner) would not work out.
			///

			/// whether all other vertices are outside the trigon?
			///
			/// get all the vertices inside the trigon:
			///

			///corner
			Complex convex = vertices.ElementAt(i);

			///convex elbow; corner start
			Complex start = vertices.ElementAt((i + count - 1) % count);

			Complex stop = vertices.ElementAt((i + count + 1) % count);
			var trigon = (
				start
				,
				convex
				,
				stop
			);

			IEnumerable<int> nontrigonCongruents = Enumerable.Range(i + 2, count - 3);

			var subtended = nontrigonCongruents.Select(i => vertices.ElementAt( i % count)).Where(
				w =>
				{
					return nilnul.geometry.planar.zone_.trigon.vsPoint.be_._has_.by_._ByCrossProductX._Has_0trigon(
										trigon
										,
					w

								);
				}).ToArray();

			if (subtended.Any())
			{
				//var subtend = (start, stop);

				return (
					convex,
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
