using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	[Obsolete()]
	public interface PointsI:nilnul.obj.StrI<Point>
		,nilnul.obj.str_.FiniteEnumI<Point>

	{

	}
	[Obsolete()]
	public class Points
		:
		PointsI
	{
		private IEnumerable<Point> _enumerable;

		public IEnumerable<Point> enumerable
		{
			get { return _enumerable; }
			set { _enumerable = value; }
		}

		public IEnumerator<Point> GetEnumerator()
		{
			return _enumerable.GetEnumerator();
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
