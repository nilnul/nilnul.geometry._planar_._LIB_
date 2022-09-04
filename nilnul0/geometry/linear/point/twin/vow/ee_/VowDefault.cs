using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point.twin.vow.ee_
{
	public class VowDefault<TVow>
		: linear.point.twin.vow.Ee
		where TVow : linear.point.twin.VowI, new()
	{
		public VowDefault(Twin val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
