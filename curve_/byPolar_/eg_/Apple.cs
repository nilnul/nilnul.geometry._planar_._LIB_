using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.planar.curve_.eg_
{
	/// <summary>
	/// r=a( 1-cos(theta) )
	/// </summary>
	public class Apple :
		nilnul.obj.Box<nilnul.num.real_.PositiveI>
	{
		public Apple(PositiveI a) : base(a)
		{
		}

		public nilnul.num.RealI rhou(nilnul.num.RealI theta) {
			return this.boxed.real.en.ToReal()
				* (
				1 - nilnul.num.real.op_.unary_.Cos.Singleton.op(theta).ToReal()
			);
		}
	}
}
