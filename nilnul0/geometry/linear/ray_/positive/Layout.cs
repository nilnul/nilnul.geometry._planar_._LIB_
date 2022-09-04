using nilnul.geometry.linear.grad.point.categorize_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.ray_.positive.vsPoint
{
	static public class _LayoutX
	{
		static public _layout.Position Layout(nilnul.geometry.linear.RayI _positive, nilnul.num.RealI point)
		{
			var vsRight = nilnul.num.real.Comparer.Singleton.Compare(point, _positive.start);

			if (vsRight < 0)
			{
				return _layout.Position.Backward;
			}
			if (vsRight == 0)
			{
				return _layout.Position.Origin;

			}
			return _layout.Position.Forward;
		}
		static public _layout.Position Layout(nilnul.num.RealI _positive, nilnul.num.RealI point)
		{
			return Layout(
				new num.real_.Positive(_positive), point
			);
		}
		static public _layout.Position _Layout(Vector _positive, PointI point)
		{


			return Layout(_positive.end.x, point.x);

		}


	}
}
