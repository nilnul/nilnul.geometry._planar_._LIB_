using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_.gon.be
{
	public class Vow4dbl
		:
		nilnul.obj.be.Vow4<
			geometry.planar.coil_.Gon4dblI
		>
		,
		geometry.planar.coil_.gon.Vow4dblI
	{
		public Vow4dbl(BeI1<Gon4dblI> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<Gon4dblI> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<Gon4dblI, bool> func) : base(func)
		{
		}
	}
}
