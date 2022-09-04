using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon_
{
	public class Antiwise4dbl
		:
		gon.be_.stokes_.neg.vow.Ee4dbl
		,
		cycle_.Polygon4dblI
	{
		public Antiwise4dbl(Polygon4dbl val) : base(val)
		{
		}

		public Antiwise4dbl(IEnumerable<Point4dblI> vs):this(new Polygon4dbl(vs))
		{
		}

		public Antiwise4dbl(Polygon4dblI x):this(
			Polygon4dbl.Of(x)
		)
		{
		}

		public Antiwise4dbl(params (double, double )[] p1):this(
			p1.Select(x=> new Point4dbl(x))
		)
		{
		}

		

		public IEnumerable<Point4dblI> vertexes => ee.vertexes;

		public IEnumerable<Grad4dbl_byPointsI> grads => this.ee.grads;
	}
}
