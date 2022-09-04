using nilnul.obj;
using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.be
{
	public class VowDbl1 :
		nilnul.obj.be.Vow4<planar.point.CoD>
		,
		planar.point.co.VowDblI
	{
		public VowDbl1(BeI1<CoD> be) : base(be)
		{
		}

		public VowDbl1(Predicate<CoD> predicate) : base(predicate)
		{
		}

		public VowDbl1(Func<CoD, bool> func) : base(func)
		{
		}
	}
}
