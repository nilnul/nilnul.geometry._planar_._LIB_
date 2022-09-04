using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_.gon_
{
	public class Poly4dbl
		:
		gon.be_.many.vow.Ee4dbl
		,
		coil_.Gon4dblI
	{
		public Poly4dbl(Gon4dblI val) : base(val)
		{
		}

		public Poly4dbl(IEnumerable<Point4dblI> vertexes)
			:
			this(new coil_.Gon4dbl(vertexes))
		{
		}

		public IEnumerable<Point4dblI> vertexes => ee.vertexes;
	}
}
