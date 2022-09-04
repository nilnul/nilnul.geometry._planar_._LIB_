using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect
{
	public class Set4dbl
		:
		nilnul.obj.set_.EqDefaulted<
			planar.Vect4dblI
			,
			planar.vect.Eq4dbl
		>
	{
		public Set4dbl()
		{
		}

		public Set4dbl(params Vect4dblI[] vars) : base(vars)
		{
		}

		public Set4dbl(IEnumerable<Vect4dblI> elements) : base(elements)
		{
		}
	}
}
