using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_.gon_.conduit.be
{
	public class Vow4dbl
		:
		nilnul.obj.be.Vow4<
			geometry.planar.coil_.gon_.Conduit4dbl
		>
		,
		geometry.planar.coil_.gon_.conduit.Vow4dblI
	{
		public Vow4dbl(BeI1<Conduit4dbl> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<Conduit4dbl> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<Conduit4dbl, bool> func) : base(func)
		{
		}
	}
}
