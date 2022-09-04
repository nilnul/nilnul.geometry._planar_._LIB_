using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.vow.ee_
{
	public class VowDefaultDbl<TVow> : EeDbl
		where TVow: co.VowDblI,new()
	{
		public VowDefaultDbl(planar.point.CoD val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
