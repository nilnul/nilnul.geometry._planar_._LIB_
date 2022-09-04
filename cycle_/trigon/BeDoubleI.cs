using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.trigon
{
	public interface BeDoubleI
		:nilnul.obj.BeI1<planar.cycle_.TriangleDbl>
	{
	}

	public interface Be4dblI
		:nilnul.obj.BeI1<planar.cycle_.Triangle4dblI>
	{
	}

	public class BeDouble :
		nilnul.obj.Be1<planar.cycle_.TriangleDbl>
		,
		BeDoubleI
	{
		public BeDouble(Func<TriangleDbl, bool> func) : base(func)
		{
		}
	}
}
