using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.band_
{
	public class AddDbl :
		co.BandOnCombineDblA
		,
		BandDblI
	{
		public PointF combine(PointF a, PointF b)
		{
			return new PointF(
				a.X + b.X
				,
				a.Y + b.Y
			);
			//throw new NotImplementedException();
		}

		public override Point4dblI combine(Point4dblI a, Point4dblI b)
		{
			return new Point4dbl(
							a.x + b.x
							,
							a.y + b.y
						);
		}

		static private Lazy<AddDbl> _Lazy = new Lazy<AddDbl>();
		static public AddDbl Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}


		static public AddDbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<AddDbl>.Instance;
			}
		}


	}
}
