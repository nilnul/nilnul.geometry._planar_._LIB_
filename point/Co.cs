
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.RealI;

namespace nilnul.geometry.planar.point
{
	public interface ICo
		:
		nilnul.obj.CoI2<planar.Point1>
	{

	}

	public  class Co:nilnul.obj.Co<Point1>
		,ICo
	{


		public Point1 begin
		{
			get { return base.Item1; }
		}


		public Point1 end
		{
			get { return base.Item2; }
		}


		public Co(Point1 point, Point1 end):base(point,end)
		{
	
		}
		public Co(PointI1 a, PointI1 b):this(new Point1(a),new Point1(b))
		{

		}


		public Co(Co duo):this(duo.begin,duo.end)
		{
		}

		

		public R length() {
			return tend._DistanceX.Distance(begin, end);
		}

		[Obsolete(nameof(planar.grad._StokesX.Stokes))]
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
