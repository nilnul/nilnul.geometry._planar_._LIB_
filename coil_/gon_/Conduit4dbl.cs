using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_.gon_
{
	public class Conduit4dbl
		:
		gon.be_.conduit.vow.Ee4dbl
	{
		public Conduit4dbl(Gon4dblI val) : base(val)
		{
		}

		public Conduit4dbl(IEnumerable<Point4dblI> vertexes)
			:
			this(new coil_.Gon4dbl(vertexes))
		{
		}
	}
}
