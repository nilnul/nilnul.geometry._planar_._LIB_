using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.vow.ee_
{
	[Obsolete()]
	public class VowDefaultD<TVow> : EeD
		where TVow: co.IVowD,new()
	{
		public VowDefaultD(planar.point.CoD val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
