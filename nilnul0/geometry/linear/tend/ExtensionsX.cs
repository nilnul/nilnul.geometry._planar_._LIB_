using nilnul.num.real.bound_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.tend
{
	static public class ExtensionsX
	{
		static public num.real.bound_.ClosedDbl ToClosedBound(double x, double y)
		{

			if (x <= y)
			{
				return new num.real.bound_.ClosedDbl(x, y);

			}

			return new num.real.bound_.ClosedDbl(y, x);
		}

		public static ClosedDbl ToClosedBound(PointDblI component, PointDblI component1)
		{
			return ToClosedBound(component.coord,component1.coord);
			//throw new NotImplementedException();
		}

		static public num.real.bound_.ClosedDbl ToClosedBound(this linear.GradDbl y)
		{
			return ToClosedBound(
				y.component, y.component1
			);
			
		}
		static public num.real.bound_.ClosedDbl ToClosedBound(this (double,double) y)
		{
			return ToClosedBound(
				y.Item1, y.Item2
			);
			
		}


		static public num.real.bound_.ClosedDbl ToClosedBound(this linear.Tend4dbl y)
		{
			return ToClosedBound(
				y.component, y.component1
			);
			
		}

	}
}
