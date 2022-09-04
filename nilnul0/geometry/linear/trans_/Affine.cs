using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.trans_
{
	/// <summary>
	/// scale first, then shift
	/// p * scale + shift.
	/// </summary>
	public interface IAffine
		:ITrans
		
	{
	}

	public class Affine4dbl
		:
		nilnul.num.real.matrix_.square_.Secondary4dbl
	{
		

		public Affine4dbl(double scale, double translate) : base(
			(scale, 0)
			,
			(translate, 1 )
		)
		{
		}

		public double trans(double coord) {
			return nilnul.num.real.matrix.co_.sociable._MultiX._Multiply_assumeSociable(
				this.boxed, new[] { coord}
			).First();
		}
	}
}
