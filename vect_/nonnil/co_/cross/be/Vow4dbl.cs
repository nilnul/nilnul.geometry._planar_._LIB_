using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil.co_.cross.be
{
	public class Vow4dbl
		:
		nilnul.obj.be.Vow4<
			nonnil.co_.Cross4dbl
		>
		,
		co_.cross.Vow4dblI
	{
		public Vow4dbl(BeI1<Cross4dbl> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<Cross4dbl> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<Cross4dbl, bool> func) : base(func)
		{
		}
	}
}
