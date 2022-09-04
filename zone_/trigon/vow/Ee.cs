using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.trigon.vow
{
	public class Ee<TVow> :
		nilnul.obj.vow.ee_.Defaultable<planar.zone_.TrigonI, TVow>
		where TVow : trigon.IVow, new()
	{
		public Ee(TrigonI val) : base(val)
		{
		}
	}
}
