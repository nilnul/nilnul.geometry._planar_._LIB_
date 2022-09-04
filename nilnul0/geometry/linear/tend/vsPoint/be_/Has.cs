using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.linear.span.vsPoint.be_
{
	static public class _HasX
	{
		static public bool Has(
			linear.Span grad
			,
			linear.PointI p

		)
		{

			if (
				nilnul.num.real.re_.Lt.Lazy.re(p.x, grad.component.x)
				||
				nilnul.num.real.re_.Gt.Lazy.re(p.x, grad.component1.x)
			)
			{
				return false;
			}
			

			return true;

		}


		static public bool Has(
			linear.SpanDbl grad
			,
			linear.PointDblI p

		)
		{

			return linear.grad.vsPoint.be_._HasX.Inside(grad, p);

		}

	}

}
