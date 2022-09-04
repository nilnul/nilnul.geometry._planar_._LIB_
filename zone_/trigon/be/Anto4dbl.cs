using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.trigon.be
{
	public class Anto4dbl
		:
		nilnul.obj.be.Anto<
			zone_.Trigon4dblI
		>
		,
		zone_.trigon.BeDoubleI
	{
		public Anto4dbl(nilnul.obj.BeI1<Trigon4dblI> be) : base(be)
		{
		}
	}
}
