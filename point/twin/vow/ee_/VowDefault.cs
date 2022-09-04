using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.twin.vow.ee_
{
	public class VowDefault<TVow> : Ee
		where TVow: planar.point.twin.VowI,new()
	{
		public VowDefault(planar.point.Twin val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
