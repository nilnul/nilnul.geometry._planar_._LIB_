
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PointD = nilnul.geometry.planar._point.PointD;
using R = nilnul.num.RealI;

namespace nilnul.geometry.planar.point
{
	[Obsolete(nameof(Duo1),true)]
	public  class Duo2
	{

		private Point___1 _begin;

		public Point___1 begin
		{
			get { return _begin; }
			set { _begin = value; }
		}

		private Point___1 _end;

		public Point___1 end
		{
			get { return _end; }
			set { _end = value; }
		}

		public Duo2(Point___1 point, Point___1 end)
		{
			_begin = point;
			_end = end;
		}

		public nilnul.num.real_.NonnegI length() {
			return co.Distance.Eval(_begin, end);
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
