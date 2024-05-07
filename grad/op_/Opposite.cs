using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.op_
{
	public class Opposite : grad.OpI
	{
		public Grad4dbl_byPointsI op(in Grad4dbl_byPointsI obj)
		{
			return new Grad4dbl_byPoints(
				obj.finish,obj.basis
			);

		}


		static public Opposite Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Opposite>.Unison;
			}
		}

	}


}
