using nilnul.geometry.planar.grad.be_.nonnil.vow;
using nilnul.num.real_;
using nilnul.obj;

namespace nilnul.geometry.planar.grad_
{

	public class Skid4dbl : planar.grad.be_.nonnil.vow.Ee4dbl
		,
		Skid4dblI
	{
		public Skid4dbl(Grad4dbl_byPointsI val) : base(val)
		{
		}

		public Skid4dbl(Step4dbl x):this(
			new Grad4dbl_byPoints(x.basis,x.end)
		)
		{
		}

		public Skid4dbl(Point4dblI item1, Point4dblI item2)
			:this(
				 new Grad4dbl_byPoints(item1,item2)
			)
		{
		}

		public Ee4dbl gradee => this;

		public Point4dblI basis => base.ee.basis;

		public Point4dblI finish => base.ee.finish;
	}




}