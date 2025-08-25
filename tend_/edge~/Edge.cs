using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry._2d.point.couple
{
	/// <summary>
	/// wrapper point.couple for use as an edge in polygon.
	/// </summary>
	public partial class Edge:Couple
	{
		public Edge(point.PointInDouble start, point.PointInDouble end)
			:base(start,end)
		{

		}


	}
}
