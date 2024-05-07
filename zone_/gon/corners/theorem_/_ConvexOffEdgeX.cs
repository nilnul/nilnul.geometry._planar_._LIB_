using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nilnul.geometry.planar.zone_.gon.corners.theorem_
{
	/// <see cref="Ge3Convex"/>
	/// <summary>
	/// given an edge, there is a convex corner which is not the peg(begin or end point) of the edge.
	/// </summary>
	/// <seealso cref="_convexOffSide_.by_._RevolvingVerticesX"/>
	static public class _ConvexOffEdgeX{

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



			int i = 0;

			int pivotIndex;

			int elbowStopIndex;

			Complex start;
			Complex pivot;
			Complex stop;

			do
			{
				start = vertices.ElementAt(i);

				pivotIndex = (++i );// % count;

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


		/// <summary>
		/// 
		/// </summary>
		/// <param name="vertices"></param>
		/// <param name="edgeStartIndex">the edge start index</param>
		/// <returns></returns>
		static public Complex _Convex_0zone_1edgeStart(
			IEnumerable<Complex> vertices
			,
			int edgeStartIndex
	
		)
		{
			
			var count = vertices.Count();

			
			edgeStartIndex =				++edgeStartIndex///now becomes the end index
				% count;


			return _Convex_0zone_1count_2elbowStart(vertices,count,edgeStartIndex);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="vertices"></param>
		/// <param name="elbowStartIndex">the elbow start index. next index is the corner pivot we are going to investigate;
		/// </param>
		/// <returns></returns>
		static public Complex _Convex_0zone_1elbowStart(
			IEnumerable<Complex> vertices
			,
			int elbowStartIndex
	
		)
		{
			var count = vertices.Count();
			return _Convex_0zone_1count_2elbowStart(vertices, count, elbowStartIndex);

		}
		static public int _Index_0zone_1elbowStart(
			IEnumerable<Complex> vertices
			,
			int elbowStartIndex
	
		)
		{
			var count = vertices.Count();
			return _Index_0zone_1count_2elbowStart(vertices, count, elbowStartIndex);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="vertices"></param>
		/// <param name="elbowStartIndex">the elbow start index. next index is the corner pivot we are going to investigate;
		/// </param>
		/// <returns></returns>
		static public Complex _Convex_0zone_1count_2elbowStart(
			IEnumerable<Complex> vertices
			,
			int count
			,
			int elbowStartIndex
	
		)
		{

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

			return pivot;

		}
		static public int _Index_0zone_1count_2elbowStart(
			IEnumerable<Complex> vertices
			,
			int count
			,
			int elbowStartIndex
	
		)
		{

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

		public static Complex _Convex_0zone_1elbowStart(IEnumerable<Complex> gon, Complex end)
		{
			return _Convex_0zone_1elbowStart(
				gon,

				gon.IndexOf( EqualityComparer<Complex>.Default, end)
			);
		}
		public static int _Index_0zone_1elbowStart(IEnumerable<Complex> gon, Complex end)
		{
			return _Index_0zone_1elbowStart(
				gon,

				gon.IndexOf( EqualityComparer<Complex>.Default, end)
			);
		}
	}


}
