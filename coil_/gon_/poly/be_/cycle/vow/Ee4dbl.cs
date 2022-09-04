using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_.gon_.poly.be_.cycle.vow
{
	public class Ee4dbl
		:
		planar.coil_.gon_.poly.vow.ee_.VowNeo4Dbl<Vow4dbl>

	{
		public Ee4dbl(Poly4dbl val) : base(val)
		{
		}

		public Ee4dbl(IEnumerable<Point4dblI> val) : this(new Poly4dbl(val))
		{
		}

	}
}
