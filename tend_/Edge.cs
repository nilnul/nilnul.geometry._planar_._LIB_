using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.geometry.planar.point;
using nilnul.geometry.planar.point.twin_;

namespace nilnul.geometry.planar.tend_
{
	/// <summary>
	/// wrapper point.couple for use as an edge in polygon.
	/// </summary>
	public class Edge : nilnul.geometry.planar.point.twin_.Dif
		,
		EdgeI
	{
		public Edge(Twin duo) : base(duo)
		{
		}

		public Edge(PointI1 a, PointI1 b) : base(a, b)
		{
		}

		public Dif pair => this;

		public Twin points => pair;
	}
}
