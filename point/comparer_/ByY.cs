using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace nilnul.geometry.planar.point.comparer_
{
	public class ByY  :ComparerI
	{
		public int Compare(PointF x, PointF y)
		{
			return nilnul.num.ieeeF.Comparer.Lazy.Compare(x.Y, y.Y);


		}

		static private Lazy<ByY> _Lazy = new Lazy<ByY>();
		static public ByY Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
