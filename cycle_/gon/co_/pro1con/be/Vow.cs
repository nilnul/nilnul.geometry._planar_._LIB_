using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon.co_.pro1con.be
{
	public class Vow4dbl
		:
		obj.be.Vow4<
			Pro1con4Dbl
		>
		,
		gon.co_.pro1con.Vow4dblI
	{
		public Vow4dbl(BeI1<Pro1con4Dbl> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<Pro1con4Dbl> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<Pro1con4Dbl, bool> func) : base(func)
		{
		}
	}
}
