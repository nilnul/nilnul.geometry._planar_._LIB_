using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.band_
{
	public class Min : BandOnCombineDblA
	{
		public PointF combine(PointF a, PointF b)
		{
			return new PointF(
				Math.Min(a.X,b.X) 
				,
				Math.Min(a.Y,b.Y)	
			);
			//throw new NotImplementedException();
		}

		public override Point4dblI combine(Point4dblI a, Point4dblI b)
		{
			return new Point4dbl(
				Math.Min(a.x,b.x) 
				,
				Math.Min(a.x,b.x)	
			);

		}


		static private Lazy<Min> _Lazy = new Lazy<Min>();
		static public Min Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
