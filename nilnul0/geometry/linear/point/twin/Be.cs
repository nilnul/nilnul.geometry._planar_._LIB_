using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point.twin
{
	public interface BeI
		:
		nilnul.obj.BeI1< linear.point.Twin>
	{
	}

	public abstract class BeA : BeI
	{
		public abstract bool be(Twin obj);
	}

	public class Be : nilnul.obj.Be1<linear.point.Twin>
		,
		BeI
	{
		public Be(Func<Twin, bool> func) : base(func)
		{
		}
	}
}
