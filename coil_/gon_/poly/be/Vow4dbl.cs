using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_.gon_.poly.be
{
	public class Vow4dbl
		:
		nilnul.obj.be.Vow4<
			geometry.planar.coil_.gon_.Poly4dbl
		>
		,
		geometry.planar.coil_.gon_.poly.Vow4dblI
	{
		public Vow4dbl(BeI1<Poly4dbl> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<Poly4dbl> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<Poly4dbl, bool> func) : base(func)
		{
		}
	}
}
