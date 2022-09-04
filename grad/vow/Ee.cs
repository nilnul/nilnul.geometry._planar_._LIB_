using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.vow
{
	public class Ee4dbl
		: nilnul.obj.vow.Ee1<
			geometry.planar.Grad4dbl_byPointsI
		>
	{
		public Ee4dbl(Grad4dbl_byPointsI val, VowI2<Grad4dbl_byPointsI> vow) : base(val, vow)
		{
		}

	}
}
