using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.trio
{
	public interface BeDblI
		:
		//nilnul.BeI<Trio1>
		//,
		nilnul.obj.BeI1<TrioD>
	{

	}

	public class BeD :
		nilnul.obj.Be1<planar.point.TrioD>
		,
		BeDblI
	{
		public BeD(Func<TrioD, bool> func) : base(func)
		{
		}
	}
}
