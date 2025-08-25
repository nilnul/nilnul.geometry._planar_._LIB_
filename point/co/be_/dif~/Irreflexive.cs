using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry._2d.point.binary.be
{
	public partial class Irreflexive
	{
		static public bool Eval(point.Binary pair) {
			return ! point.PointInDouble.Eq.Eval(pair.point, pair.point1);
		}

		public class Be:
			nilnul.bit.Be<point.Binary>
		{
			public Be()
				:base(Eval)
			{

			}

		}

		public class Assert
			:nilnul.bit.be.Assert<point.Binary,Be>
		{
			static public Assert Singleton = SingletonByDefault<Assert>.Instance;
			
		}



		public class Asserted:
			nilnul.bit.be.Asserted<point.Binary,Be>
		{

			public Asserted(point.Binary pair)
				:base(pair)
			{

			}

			public Asserted(PointInDouble start,PointInDouble end)
				:this(new Binary(start,end))
			{


			}

			public Asserted(double startX, double startY, double endX, double endY)
				:this(new PointInDouble(startX,startY),new PointInDouble(endX,endY))
			{

				
			}

			public point.PointInDouble start {
				get {
					return val.point;
				}
				internal set {
					this.val.point = value;
				}
				
			}
			public point.PointInDouble end {
				get {
					return val.point1;
				}
				internal set {
					this.val.point1 = value;
				}
			}

			public double angle
			{
				get
				{
					return nilnul.geometry._2d.point.Angle.Eval_0to2pi(this.end.x - this.start.x, this.end.y - this.start.y);

				}
			}


		}






	}
}
