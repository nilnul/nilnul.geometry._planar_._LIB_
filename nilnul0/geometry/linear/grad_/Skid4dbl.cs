using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.grad_
{
	public interface ISkid:IGrad { }
	public class Skid4dbl :
		linear.GradDbl
	{
		public Skid4dbl(linear.point.co.be_.dif.vow.Ee4dbl ee) : base(ee.ee)
		{

		}
		public Skid4dbl(linear.point.CoDbl item1) :
			this(
				new point.co.be_.dif.vow.Ee4dbl( item1)
			)
		{
		}

		public Skid4dbl(linear.PointDblI item1, linear.PointDblI item2) :
			this(
				new point.CoDbl( item1, item2)
			)
		{
		}

		public Skid4dbl(double tgtStart, double tgtEnd) : this(
			new point.CoDbl(
			tgtStart
			,
			tgtEnd
				)
			)
		{
		}
	}
}
