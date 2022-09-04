using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.be.vow_
{
	public class BeDefaultDbl1<TBe>
		:
		planar.point.co.be.VowDbl1
		where TBe : point.co.BeDblI, new()
	{
		public BeDefaultDbl1() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}


		

		static public BeDefaultDbl1<TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BeDefaultDbl1<TBe>>.Instance;
			}
		}

	}
}
