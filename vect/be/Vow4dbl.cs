using nilnul.obj;
using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.be
{
	public class Vow4dbl
		: nilnul.obj.be.Vow4<planar.Vect4dblI>
		,
		planar.vect.Vow4dblI
	{
		public Vow4dbl(BeI1<Vect4dblI> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<Vect4dblI> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<Vect4dblI, bool> func) : base(func)
		{
		}
	}
}
