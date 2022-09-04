using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon_.antiwise.str_
{
	public class Disjoint
		:
		str.vow.ee_.VowNeo<
			gon_.antiwise.str.be_.disjoint.Vow
		>
	{
		public Disjoint(IEnumerable<Antiwise4dbl> val) : base(val)
		{
		}

		public Disjoint(IEnumerable<IEnumerable<Point4dblI>> cycles)
			:this(cycles.Select(vs=> new Antiwise4dbl(vs)))
		{
		}

		public Disjoint(IEnumerable<Polygon4dblI> children)
			:this(
				 children.Select(x=> new Antiwise4dbl(x))
			)
		{
		}
	}
}
