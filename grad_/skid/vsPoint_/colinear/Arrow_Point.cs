using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.ray.co.be_.coline
{
	public partial class Point_To_Arrow
	{
		static public Position _Eval_Position( point.PointInDouble point,Arrow arrow) {

			var sinceStart = s.be.parallel.Distance.Eval(arrow, arrow.start, point);

			var sinceEnd = s.be.parallel.Distance.Eval(arrow, arrow.end, point);
			if (sinceStart<0)
			{
				return Position.Lag;
				
			}

			if (sinceStart == 0)
			{


				return Position.Start;
			}
			if (sinceEnd<0)
			{
				return Position.Middle;
				
			}

			if ( sinceEnd==0) return Position.End;
			return Position.Ahead;
		
		}

		static public Position _Eval_Position(Arrow arrow, point.PointInDouble point) {

			var sinceStart = s.be.parallel.Distance.Eval(arrow, arrow.start, point);

			var sinceEnd = s.be.parallel.Distance.Eval(arrow, arrow.end, point);
			if (sinceStart<0)
			{
				return Position.Lag;
				
			}

			if (sinceStart == 0)
			{


				return Position.Start;
			}
			if (sinceEnd<0)
			{
				return Position.Middle;
				
			}

			if ( sinceEnd==0) return Position.End;
			return Position.Ahead;
		
		}
		public enum Position{
			Lag
			,
			Start,
			Middle,
			End,
			Ahead
		}
	}
}
