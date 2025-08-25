using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry._2d.point.couple.be
{
	public partial class Irreflexive
	{
		static public bool Eval(point.Pair pair) {
			return ! PointD.Eq.Eval(pair.point, pair.point1);
		}

		public class Be:
			nilnul.bit.Be<point.Pair>
		{
			public Be()
				:base(Eval)
			{

			}

		}

		public class Assert
			:nilnul.bit.be.Assert<point.Pair,Be>
		{
			static public Assert Singleton = SingletonByDefault<Assert>.Instance;
			
		}



		public class Asserted:
			nilnul.bit.be.Asserted<point.Pair,Be>
		{
			public Asserted(point.Pair pair)
				:base(pair)
			{

			}

			public PointD start {
				get {
					return val.point;
				}
			}
			public PointD end {
				get {
					return val.point1;
				}
			}

			public double angle
			{
				get
				{
					return nilnul.geometry._2d.point.Angle.Eval_0to2pi(this.val.point.x - this.val.point1.x, this.val.point.y - this.val.point1.y);

				}
			}


		}






	}
}
