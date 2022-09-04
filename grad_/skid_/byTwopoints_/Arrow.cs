using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.point;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;

using nilnul.geometry.planar.point.co.be_.dif;
using nilnul.geometry.planar.point.co.be_.dif.vow;

namespace nilnul.geometry.planar.grad_
{

	public class Arrow
		: nilnul.geometry.planar.point.co.be_.dif.vow.Ee
		,
		IArrow

	{
		

		public Arrow(planar.point.Co duo) : base(duo)
		{

		}

		public Arrow(Point1 point, Point1 end):this(new Co(point,end))
		{
			
		}

		
		public Arrow(PointI1 point, PointI1 end):this(new Co(point,end))
		{
			
		}

		public Point1 start { get { return boxed.Item1; } }

		public Point1 stop { get { return boxed.Item2; } }

		public rotation_.Direction direction {
			get {
				return skid._DirectionX._Direction_assumeDif(
					 this.ee.begin, this.ee.end
				);
			}
		}

		public Ee points => this;
	}
}
