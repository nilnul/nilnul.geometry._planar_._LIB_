using nilnul.geometry.planar.point.trio.be_.tripod.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.trigon_
{
	/// <summary>
	/// the trigon's points are in postive rotation
	/// </summary>
	public class Positive4dbl
		: trigon.be_.positive.vow.Ee4dbl
		,
		planar.zone_.Trigon4dblI
	{
		public Positive4dbl(TriangleDbl val) : base(val)
		{
		}
		public Positive4dbl(Triangle4dblI v):this(  TriangleDbl.Of(v))
		{

		}

		static public Positive4dbl OfByEnsureOrient(TriangleDbl val) {

			
			return new Positive4dbl(
				cycle_.trigon.op_.unary_.EnsureFacade.Singleton.op(val)
			);
		}

		public EeD points => this;

		public IEnumerable<Point4dblI> vertexes => points.ee;

		public IEnumerable<Grad4dbl_byPointsI> grads => base.ee.grads;
	}
}
