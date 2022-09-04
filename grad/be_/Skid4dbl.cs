using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.be_
{
	public class Skid4dbl
		:
		nilnul.geometry.planar.grad.Be4dblI
	{
		public bool be(Grad4dbl_byPointsI obj)
		{
			return nilnul.geometry.planar.point.co.be_.Dif.Singleton.be(
				obj.basis,obj.finish

			);

		}

		static public Skid4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Skid4dbl>.Instance;
			}
		}

	}
}
