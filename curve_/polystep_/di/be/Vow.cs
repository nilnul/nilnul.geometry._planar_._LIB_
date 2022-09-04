using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.polystep_.di.be
{
	public class Vow4dbl
		:
		nilnul.obj.be.Vow4<
			polystep_.Di4dbl
		>
		,
		di.Vow4dblI
	{
		public Vow4dbl(BeI1<Di4dbl> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<Di4dbl> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<Di4dbl, bool> func) : base(func)
		{
		}

		public void vow(Point4dblI basis1, Point4dblI basis2, Point4dblI finish)
		{
			vow(
				new polystep_.Di4dbl(basis1, basis2, finish)
			);
			//throw new NotImplementedException();
		}
	}
}
