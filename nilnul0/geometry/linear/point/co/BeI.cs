using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point.co
{
	public interface BeI:nilnul.obj.BeI1<linear.point.Co>
	{
	}

	public abstract class BeA : nilnul.obj.co.BeA<linear.PointI, linear.point.Co>,BeI
	{
	}
	public class Be :
		nilnul.obj.Be1<linear.point.Co>
		,
		BeI
	{
		public Be(Func<Co, bool> func) : base(func)
		{
		}
	}
}
