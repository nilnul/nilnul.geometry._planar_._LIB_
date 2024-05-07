using nilnul.geometry.planar.rotation_;
using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.ray.vsPoint
{
	static public class _LayoutX
	{
		static public _layout.Category Layout(Ray dir, Point1 point)
		{
			if (point == dir.src)
			{
				return _layout.Category.Origin;
			}


			var t = Angle.Ov(dir, point).azimuth.Direction().en.ToReal();

			if (t == 0)
			{
				return _layout.Category.Forward;
			}
			if (t > 0)
			{
				return _layout.Category.Lift;
			}
			//if (t<0)
			//{
			if (t == -nilnul.num.real_.TauX.Half)
			{
				return _layout.Category.Backward;
			}
			return _layout.Category.Retract;

			//}
			;

		}
	}
}
