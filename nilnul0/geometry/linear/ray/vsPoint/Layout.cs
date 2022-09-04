using nilnul.geometry.linear.grad.point.categorize_;
using nilnul.geometry.linear.ray.convert_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.ray.vsPoint
{
	static public class _LayoutX
	{
		static public ray_.positive.vsPoint._layout.Position Layout(
			nilnul.geometry.linear.RayI ray
			,
			nilnul.num.RealI point
		)
		{
			if (ray.direction)
			{
				return ray_.positive.vsPoint._LayoutX.Layout(ray, point);
			}
			return ray_.positive.vsPoint._LayoutX.Layout(
				ray.Neg()
				,
				nilnul.num.real.op_.unary_.Neg.Singleton.op( point)
			);
		}
	}
}