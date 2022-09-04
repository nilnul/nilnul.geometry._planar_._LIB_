using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.bag.be
{
	public class EnDbl
		: nilnul.obj.be.En4<nilnul.geometry.planar.point.BagDbl>
	{
		public EnDbl(BagDbl obj, BeI1<BagDbl> be) : base(obj, be)
		{
		}

		public EnDbl(BagDbl obj, Predicate<BagDbl> predicate) : base(obj, predicate)
		{
		}

		public EnDbl(BagDbl obj, Func<BagDbl, bool> predicate) : base(obj, predicate)
		{
		}
	}
}
