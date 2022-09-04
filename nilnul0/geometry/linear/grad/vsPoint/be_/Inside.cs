using nilnul.geometry.linear.grad.point.categorize_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.geometry.linear.grad.vsPoint.be_
{
	static public class _HasX
	{

		static public bool Inside(linear.Grad1 grad, Point p)
		{
			return nilnul.geometry.linear.vect.vsPoint.be_._HasX.Has(
				grad.Vector()
				,
				p - grad.Item1
			);
		}

		static public bool Inside(linear.GradDbl grad, PointDblI p)
		{
			return nilnul.geometry.linear.vect.vsPoint.be_._HasX.Has(
				grad.Vector()
				,
				p.ToClass() - grad.Item1
			);
		}

		public static bool Inside(SpanDbl grad, PointDblI p)
		{
			return Inside(
				new linear.GradDbl(
					grad.Order()
				)
				,
				p
			);
		}
	}


}
