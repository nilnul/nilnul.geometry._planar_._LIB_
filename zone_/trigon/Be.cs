using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.trigon
{
	public interface IBe
		:nilnul.obj.BeI1<planar.zone_.TrigonI>
	{
	}

	public abstract class BeA : IBe
	{
		public abstract bool be(Triangle obj);
		public bool be(TrigonI obj) {
			return be( new Triangle(obj));
		}
	}

	public class Be :
		nilnul.obj.Be1<planar.zone_.TrigonI>
		,
		IBe
	{
		public Be(Func<TrigonI, bool> func) : base(func)
		{
		}
	}


}
