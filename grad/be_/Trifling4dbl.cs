using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.be_
{
	public class Trifling4dbl
		:
		nilnul.geometry.planar.grad.Be4dblI
	{
		public bool be(Grad4dbl_byPointsI obj)
		{
			return nilnul.geometry.planar.point.re_.Approx4dbl.Singleton.re(
				obj.basis,obj.finish

			);
		}

		static public Trifling4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Trifling4dbl>.Instance;
			}
		}

	}
}
