using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Point1 = nilnul.geometry.planar._point.PointD;
using PointD = nilnul.geometry.planar._point.PointD;

namespace nilnul.geometry.planar.point.duo.be
{
	public class Irreflexive
	{
		static public bool Eval(Duo duo) {

			return duo.begin == duo.end;

		}

		static public bool Eval(PointD point, PointD point1) {

			return Eval(new Duo(point,point1));

		}


		public class Be
			:nilnul.bit.Be<Duo>
		{
			public Be()
				:base(Eval)
			{


			}

			public class Assert :nilnul.bit.be.Assert<Duo,Be>
			{


				static public void Eval(PointD point,PointD point1) {

					Eval(new Duo(point, point1));

				}

				

			}

			public class Asserted :nilnul.bit.be.Asserted<Duo,Be>
			{
				public Asserted(Duo duo)
					:base(duo)
				{

				}

				public double angle() {
					return point.b.NonZero.Asserted._Angle_nonZeroPoint(val.end.x - val.begin.x, val.end.y - val.begin.y);
				}

				public double distance() {
					return point.DuoX.Distance(val);
				}



			}

		}
	}
}
