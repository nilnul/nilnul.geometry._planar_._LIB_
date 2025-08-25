using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar._point.pointD
{
	public partial class Duo
	{
		private PointD _begin;

		public PointD begin
		{
			get { return _begin; }
			set { _begin = value; }
		}

		private PointD _end;

		public PointD end
		{
			get { return _end; }
			set { _end = value; }
		}

		public Duo(PointD point, PointD end)
		{
			_begin = point;
			_end = end;
		}

		public double distance() {
			var xShift = _end.x - _begin.x;
			var yShift = _end.y - _begin.y;
			return Math.Sqrt(
				xShift*xShift
				+yShift*yShift
				
				
			);
		}

		public double integral()
		{

			//trapoid
			return (end.x - begin.x) * (end.y + begin.y) / 2;

			throw new NotImplementedException();

		}



	}
}
