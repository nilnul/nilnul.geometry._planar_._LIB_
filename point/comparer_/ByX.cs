using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace nilnul.geometry.planar.point.comparer_
{
	[Obsolete()]
	public class ByX  :ComparerI
	{
		public int Compare(PointF x, PointF y)
		{
			return nilnul.num.ieeeF.Comparer.Lazy.Compare(x.X, y.X);
		}

		static private Lazy<ByX> _Lazy = new Lazy<ByX>();
		static public ByX Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
