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
	/// r=a( 1-cos(theta) ), like apple or ass
	/// </summary>
	public class AppleDbl :
		nilnul.obj.Box<nilnul.num.real_.PositiveDbl>
	{
		public AppleDbl(nilnul.num.real_.PositiveDbl a) : base(a)
		{
		}

		public AppleDbl(int v):this(new PositiveDbl(v))
		{
		}

		public nilnul.num.real_.NonnegOfDouble rhou(double theta) {
			return new NonnegOfDouble( this.boxed*(1-Math.Cos(theta)) );
		}
	}
}
