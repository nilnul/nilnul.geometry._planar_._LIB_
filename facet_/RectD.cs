
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.facet_
{
	public class RectD
	{
		private Point4dbl _a;

		public Point4dbl a
		{
			get { return _a; }
			//set { _a = value; }
		}

		private Point4dbl _b;

		public Point4dbl b
		{
			get { return _b; }
			//set { _b = value; }
		}

		private Point4dbl _c;

		public Point4dbl c
		{
			get { return _c; }
			//set { _c = value; }
		}
		//private PointDbl _d;

		public Point4dbl d
		{
			get {
				
				return c+ (a-b);

		}
			//set { _d = value; }
		}

		private RectD(Point4dbl a, Point4dbl b, Point4dbl c)
		{
			_a = a;
			_b = b;
			_c = c;
			//_d = d;
		}

		static public RectD CreateByDrag(Point4dbl origin, VectorDbl drag) {
			return new RectD(
				origin,
				origin + drag.getXFactor()
				,
				origin + drag.getYFactor()
				//,
				//origin + drag
			);
		}


	}
}
