using nilnul.bit.combine_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.bag
{
	public interface BeDblI
		:nilnul.obj.BeI1< nilnul.geometry.planar.point.BagDbl>
	{
	}

	public class BeDbl : nilnul.obj.Be1<nilnul.geometry.planar.point.BagDbl>
		,
		BeDblI
	{
		public BeDbl(Func<BagDbl, bool> func) : base(func)
		{
		}

		public BeDbl(Predicate<BagDbl> predicate) : base(predicate)
		{
		}
	}
}
