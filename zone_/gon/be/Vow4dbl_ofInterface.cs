using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon.be
{
	public class Vow4dbl_ofInterface
		:
		obj.be.Vow4<
			Polygon4dblI
		>
		,
		gon.Vow4dbl_ofInterfaceI
	{
		public Vow4dbl_ofInterface(BeI1<Polygon4dblI> be) : base(be)
		{
		}

		public Vow4dbl_ofInterface(Predicate<Polygon4dblI> predicate) : base(predicate)
		{
		}

		public Vow4dbl_ofInterface(Func<Polygon4dblI, bool> func) : base(func)
		{
		}
	}
}
