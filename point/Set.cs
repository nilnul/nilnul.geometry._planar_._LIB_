using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point
{
	public interface ISet :nilnul.obj.ISet<IPoint>{ }
	public class SetDbl
		: nilnul.obj.set_.EqDefaulted<Point4dbl, point.EqDbl>
	{
		public SetDbl()
		{
		}

		public SetDbl(params Point4dbl[] vars) : base(vars)
		{
		}

		public SetDbl(IEnumerable<Point4dbl> elements) : base(elements)
		{
		}

		

	
	}
}
