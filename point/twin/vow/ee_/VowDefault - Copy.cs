using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.twin.vow.ee_
{
	public class VowDefaultD<TVow> : EeD
		where TVow: planar.point.twin.IVowD,new()
	{
		public VowDefaultD(planar.point.TwinD val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
