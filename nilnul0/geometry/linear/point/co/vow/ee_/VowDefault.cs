using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point.co.vow.ee_
{
	public class VowDefault<TVow>
		: linear.point.co.vow.Ee
		where TVow: linear.point.co.VowI,new()
	{
		public VowDefault(Co val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
