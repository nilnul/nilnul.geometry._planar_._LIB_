using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tope_.bloc
{
	static public class _AreaX
	{
		static public double _Area_01nonneg(double x, double y) {
			return x * y;
		}

		public static double _Area_01nonneg((double, double) y)
		{
			return _Area_01nonneg(y.Item1, y.Item2);
			//throw new NotImplementedException();
		}

		public static int Area(Size x)
		{
			return x.Width * x.Height;
		}
	}
}
