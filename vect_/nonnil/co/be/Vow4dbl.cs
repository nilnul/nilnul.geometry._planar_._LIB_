using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil.co.be
{
	public class Vow4dbl
		:
		nilnul.obj.be.Vow4<
			nonnil.Co4dbl
		>
		,
		co.Vow4dblI
	{
		public Vow4dbl(BeI1<Co4dbl> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<Co4dbl> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<Co4dbl, bool> func) : base(func)
		{
		}
	}
}
