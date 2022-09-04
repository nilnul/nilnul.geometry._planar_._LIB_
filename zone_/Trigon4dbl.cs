using nilnul.geometry.planar.cycle_;
using nilnul.geometry.planar.point.trio.be_.tripod.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_
{
	/// <summary>
	/// the trigon's points are in postive rotation
	/// </summary>
	/// the default is defined by one edge from 0 to positive x. a 3rd point inner the +y halfplane <see cref="planar.surface_.sected_.WaiPositive"/>.
	public class TriangleDbl
		: cycle_.trigon.be_.positive.vow.Ee4dbl
		,
		planar.zone_.Trigon4dblI
		,
		planar.zone_.Polygon4dblI
	{
		public TriangleDbl(cycle_.TriangleDbl val) : base(val)
		{
		}

		public TriangleDbl(EeD points1):this(new cycle_.TriangleDbl(points1) )
		{
		}

		public TriangleDbl(Point4dblI v0, Point4dblI v01, Point4dblI v2)
			:this(
				 new cycle_.TriangleDbl(v0,v01,v2)

				 )
		{
		}


		public TriangleDbl(double v1, double v2, double v3, double v4, double v5, int v6)
			:this(
				 new cycle_.TriangleDbl(v1,v2,v3,v4,v5,v6)
				)
		{
		}
		static public TriangleDbl OfByReorient(Point4dblI v0, Point4dblI v01, Point4dblI v2)
		{

			return OfByReorient(
new cycle_.TriangleDbl(v0, v01, v2)
			);

		}

		private static TriangleDbl OfByReorient(cycle_.TriangleDbl c)
		{
			
				return new TriangleDbl(

					cycle_.trigon_.Positive4dbl.OfByEnsureOrient(c)
				);
			

		}

		public EeD points => this;

		public IEnumerable<Point4dblI> vertexes => points.ee;

		public IEnumerable<Grad4dbl_byPointsI> grads => new[] {this.ee.arrow0th,this.ee.arrow1st,this.ee.arrow2nd };
	}
}
