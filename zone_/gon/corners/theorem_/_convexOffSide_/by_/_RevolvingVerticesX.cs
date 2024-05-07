using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nilnul.geometry.planar.zone_.gon.corners.theorem_._convexOffSide_.by_
{
	/// <see cref="Ge3Convex"/>
	/// given an edge, there is a convex corner which is not the peg(begin or end point) of the edge.
	/// <summary>
	/// revolve the vertexes such that the edge is (-1, 0), where -1 means count-1.
	/// </summary>
	/// <remarks>
	/// that is: there must be a corner indexed at not the first nor the last.
	/// </remarks>
	static public class _RevolvingVerticesX{

		/// <summary>
		/// skip first one and last vertexes; among the inbetween vertexes, there is at least one that is convex;
		/// </summary>
		/// <param name="vertices"></param>
		/// <returns></returns>
		/// <see cref="_Convex_0zone_1elbowStart(IEnumerable{Complex}, int)"/> where the edge index is that of last vertex.
		static public Complex _Convex_0zone(
			IEnumerable<Complex> vertices
	
		)
		{
			///find first convex corner:
			var count = vertices.Count();



			int elbowStart = 0;

			int pivotIndex;

			int elbowStopIndex;

			Complex start;
			Complex pivot;
			Complex stop;

			do
			{
				start = vertices.ElementAt(elbowStart);

				pivotIndex = (++elbowStart );// % count;

				pivot = vertices.ElementAt(pivotIndex);

				elbowStopIndex = ++pivotIndex ;// % count;

				stop = vertices.ElementAt(elbowStopIndex);

			} while (
					geometry.planar.curl_.elbow.be_._NonProwindX._Be_ofElbow(
						 start, pivot, stop
					)
			);

			return pivot;

		}


		static public int _Index_0zone(
			IEnumerable<Complex> vertices
	
		)
		{
			var count = vertices.Count();
			return _Index_0zone_1count(vertices, count);

		}

	
		static public int _Index_0zone_1count(
			IEnumerable<Complex> vertices
			,
			int count
	
		)
		{

			int elbowStartIndex = 0;
			int pivotIndex;
			int elbowStopIndex;

			Complex start;
			Complex pivot;
			Complex stop;

			do
			{
				start = vertices.ElementAt(elbowStartIndex);

				pivotIndex = (++elbowStartIndex %count);// % count;

				pivot = vertices.ElementAt(pivotIndex);

				elbowStopIndex = ( ++pivotIndex )%count ;// % count;

				stop = vertices.ElementAt(elbowStopIndex);



			} while (
					geometry.planar.curl_.elbow.be_._NonProwindX._Be_ofElbow(
						 start, pivot, stop
					)
			);

			return pivotIndex;

		}

	}


}
