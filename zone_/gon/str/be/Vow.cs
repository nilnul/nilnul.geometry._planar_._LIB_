using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon.str.be
{
	public class Vow
		:
		nilnul.obj.be.Vow4<IEnumerable<zone_.Polygon4dblI>>
	{
		public Vow(BeI1<IEnumerable<Polygon4dblI>> be) : base(be)
		{
		}

		public Vow(Predicate<IEnumerable<Polygon4dblI>> predicate) : base(predicate)
		{
		}

		public Vow(Func<IEnumerable<Polygon4dblI>, bool> func) : base(func)
		{
		}
	}
}
