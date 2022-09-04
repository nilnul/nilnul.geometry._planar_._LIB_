using nilnul.geometry.linear.grad.point.categorize_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect_.nonneg_.notnil.as_.basis.of_.vector.categorize_
{
	static public class _InsideX
	{

		static public _inside.Category _Inside(Vector _positive, Vector p)
		{



			var vsZero = nilnul.num.real.Sign.Singleton.sign(p.x);


			var vsRight = nilnul.num.real.Comparer.Singleton.Compare(p.x, _positive.x);

			if (vsZero == false)
			{
				return _inside.Category.Left;
			}
			if (vsZero == null )
			{
				return _inside.Category.AtLeftEnd;
			}

			if (vsRight <0)
			{
				return _inside.Category.InBetween;
			}
			if (vsRight ==0)
			{
				return _inside.Category.AtRightEnd;

			}
			return _inside.Category.Right;

		}

	}
}
