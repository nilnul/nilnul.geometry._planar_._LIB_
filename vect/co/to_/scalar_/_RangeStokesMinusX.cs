using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.co
{
	static public class _RangeStokesMinusX
	{
		static public double RangeStokesMinus(Vect4dblI v1, Vect4dblI v2) {
			return v1.InnerProduct() - v2.InnerProduct();
		}

		/// <summary>
		/// this is a dif, the <see cref="nilnul.obj.op_.binary.Converse{T}"/> of minus.
		/// like <see cref="nilnul.num.real.op_.binary_.Minus"/> and <see cref="nilnul.num.real.op_.binary_.Dif"/>
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		static public double RangeStokesDif(Vect4dblI v1, Vect4dblI v2) {
			return -RangeStokesMinus(v1,v2);
		}

	}
}
