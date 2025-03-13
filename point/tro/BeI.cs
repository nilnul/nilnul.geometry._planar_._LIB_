using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.trio
{
	public interface BeI
		:
		//nilnul.BeI<Trio1>
		//,
		nilnul.obj.BeI1<Trio>
	{

	}

	public class Be :
		nilnul.obj.Be1<planar.point.Trio>
		,
		BeI
	{
		public Be(Func<Trio, bool> func) : base(func)
		{
		}
	}
}
