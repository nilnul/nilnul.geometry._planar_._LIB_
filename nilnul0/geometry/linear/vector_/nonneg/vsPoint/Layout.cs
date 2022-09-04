using nilnul.geometry.linear.grad.point.categorize_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect_.nonneg.vsPoint
{
	static public class _LayoutX
	{
		static public positive.vsPoint._layout.Category Layout(nilnul.num.real_.NonnegI _positive, nilnul.num.RealI point)
		{

			var vsZero = nilnul.num.real.Sign.Singleton.sign(point);


			var vsRight = nilnul.num.real.Comparer.Singleton.Compare(point, _positive);

			if (vsZero == false)
			{
				return positive.vsPoint._layout.Category.Behind;
			}
			if (vsZero == null)
			{
				return positive.vsPoint._layout.Category.Start;
			}

			if (vsRight < 0)
			{
				return positive.vsPoint._layout.Category.Between;
			}
			if (vsRight == 0)
			{
				return positive.vsPoint._layout.Category.Stop;
			}
			return positive.vsPoint._layout.Category.Forward;
		}
		static public positive.vsPoint._layout.Category Layout(nilnul.num.RealI _positive, nilnul.num.RealI point)
		{
			return Layout(
				new num.real_.Positive(_positive), point
			);
		}
		static public positive.vsPoint._layout.Category _Layout(Vector _positive, PointI point)
		{


			return Layout(_positive.end.x, point.x);

		}


	}
}
