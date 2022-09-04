using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.geometry.planar.points.op_.unary_
{
	public class SortDbl : UnaryDblI
	{
		private point.ComparerDblI _pointComparer;

		public point.ComparerDblI pointComparer
		{
			get { return _pointComparer; }
			//set { _pointComparer = value; }
		}

		public SortDbl(point.ComparerDblI pointComparer)
		{
			_pointComparer = pointComparer;

		}
		public IEnumerable<Point4dbl> op(IEnumerable<Point4dbl> arg)
		{
			return arg.OrderBy(x => x, _pointComparer);
			//throw new NotImplementedException();
		}
		static public SortDbl CreateByHorizon() {
			return new SortDbl(
					point.comparer_.Horizon.Lazy
				);
		}

	
	}
}
