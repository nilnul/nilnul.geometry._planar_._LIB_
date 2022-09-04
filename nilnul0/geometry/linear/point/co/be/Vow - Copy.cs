using nilnul.obj;
using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point.co.be
{
	

	public class Vow4dbl :
		nilnul.obj.be.Vow4<
		linear.point.CoDbl
			>
	{
		public Vow4dbl(BeI1<CoDbl> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<CoDbl> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<CoDbl, bool> func) : base(func)
		{
		}
	}
}
