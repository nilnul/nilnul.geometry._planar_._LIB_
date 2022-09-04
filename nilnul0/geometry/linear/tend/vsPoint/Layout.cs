using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.linear.span.vsPoint
{
	static public class _LayoutX
	{
		static public bool? Inside(
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
			if (
				new nilnul.num.real.Set(
grad.component.x
, grad.component1.x
				).Contains(p.x)


			)
			{
				return null;
			}

			return true;

		}

	}

}
