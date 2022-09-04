using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.facet_.holed_.gon.to_
{
	/// <summary>
	/// find mutually visible vertices.
	/// </summary>
	public interface ICoil:
		ITo<
			geometry.planar.coil_.gon_.IEnclosureAtEdge
	>
	{
		/*
		  find the x maximum vertexes of the inner gon
		,
		the ray from this vertex to x-poistive direction, will reach some point in an edge.
		this forms a triangle with another point of the edge.

		If some vertexes of the outer lie within the triangle
		find the one which is nearest to the abovementioned inner vertex.
		 */
	}
}
