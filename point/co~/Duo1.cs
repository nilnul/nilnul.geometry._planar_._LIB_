
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PointD = nilnul.geometry.planar._point.PointD;
using R = nilnul.num.RealI;

namespace nilnul.geometry.planar.point
{

	[Obsolete()]
	public  class Duo1:nilnul.obj.Duo<Point>
	{


		public Point begin
		{
			get { return Item1; }
		}


		public Point end
		{
			get { return Item2; }
		}

		public Duo1(Point point, Point end):base(point,end)
		{
	
		}
		


		public Duo1(Duo1 duo):this(duo.begin,duo.end)
		{
		}

		public Duo1(PointI point, PointI end1)
			:this(
				new Point(point), new Point(end1) 
			)
		{

		}

		public R length() {
			return co.Distance.Eval(begin, end);
		}

		public R integral()
		{

			//trapoid


			return nilnul.num.real.co_.divisible._DivX.Bind(
				nilnul.num.real.op_.binary_.Multi.Singleton.op(
				
					nilnul.num.real.op_.binary_.Minus.Singleton.op (end.x , begin.x)
					,
					nilnul.num.real.op_.binary_.Add.Singleton.op(end.y , begin.y) 
				)
				
				, 2
			);

			//throw new NotImplementedException();

		}

		



	}
}
