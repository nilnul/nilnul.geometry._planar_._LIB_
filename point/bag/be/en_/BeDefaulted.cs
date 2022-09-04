using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.bag.be.en_
{
	public class BeDefaultedDbl<TBe>
		: bag.be.EnDbl
		where TBe : bag.BeDblI, new()
	{
		public BeDefaultedDbl(BagDbl obj) : base(obj, nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		
	}
}
