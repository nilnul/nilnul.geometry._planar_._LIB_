using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon
{
	/// <summary>
	/// an edge might be decomposed into several <see cref="planar.IGrad"/> including trivia ones.
	/// after being reduced, edge is the same as <see cref="planar.grad_.ISkid"/>.
	/// When we categorize gons into hexagon, trigon, and other polygon, the number of edges refers to the number of edge after being reduced.
	/// </summary>
	public interface IEdge
	{
	}
}
