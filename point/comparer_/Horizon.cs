using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.comparer_
{
	public class Horizon : ComparerDblI
	{
		public int Compare(Point4dbl x, Point4dbl y)
		{
			return nilnul.num.ieee.Comparer.Lazy.Compare(x.x, y.x);


		}

		static private Lazy<Horizon> _Lazy = new Lazy<Horizon>();
		static public Horizon Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
