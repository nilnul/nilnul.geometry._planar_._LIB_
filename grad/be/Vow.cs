using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.be
{
	public class Vow
		:
		nilnul.obj.be.Vow4<
			geometry.planar.Grad4dbl_byPointsI
		>
		,
		geometry.planar.grad.Vow4dblI
	{
		public Vow(BeI1<Grad4dbl_byPointsI> be) : base(be)
		{
		}

		public Vow(Predicate<Grad4dbl_byPointsI> predicate) : base(predicate)
		{
		}

		public Vow(Func<Grad4dbl_byPointsI, bool> func) : base(func)
		{
		}
	}
}
