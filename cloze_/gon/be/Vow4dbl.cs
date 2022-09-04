using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.gon.be
{
	public class Vow4dbl
		:
		nilnul.obj.be.Vow4<
			geometry.planar.cloze_.Polygon4dblI
		>
		,
		geometry.planar.cloze_.gon.Vow4dblI
	{
		public Vow4dbl(BeI1<Polygon4dblI> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<Polygon4dblI> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<Polygon4dblI, bool> func) : base(func)
		{
		}
	}
}
