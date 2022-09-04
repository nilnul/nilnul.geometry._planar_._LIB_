using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

using nilnul.geometry.linear.vector.duo.categorize_._inside;

namespace nilnul.geometry.linear.grad.point.categorize_
{
	


	static public class _InsideX
	{
		static public Category Inside(Grad grad, Point p) {

			if (linear.grad.be_.NonNeg.Singleton.be(grad) )
			{
				return _Position(grad,p);
			}
			return _Position(
				nilnul.geometry.linear.grad.op_.Reverse.Singleton.op(grad)
				,p
			);
		}

		static public Category _Position(
			Grad _grad_nonNeg
			,
			Point p
			
		) {

			var pCached = new point_.Cached(p);

			var minusLeft = nilnul.num.real.Sign.Singleton.sign(pCached.coord - _grad_nonNeg.Item1.coord.ToReal());


			var minusRight = nilnul.num.real.Sign.Singleton.sign( pCached.coord - _grad_nonNeg.Item2.coord.ToReal() );


			if (minusLeft ==false )
			{
				return Category.Left;

			}
			if (minusRight ==true)
			{
				return Category.Right;
			}
			if (minusLeft ==null )
			{
				if (minusRight ==null)
				{
					return Category.AtBothEnd;
				}
				return Category.AtLeftEnd;

			}
			//minusLeft == true
			if (minusRight ==null)
			{
				return Category.AtRightEnd;
			}
			//minusRight == false
			return Category.InBetween;
			

		}

	}
	public class Inside
	{
	}
}
