using nilnul.geometry.planar.point;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.geometry.planar.point._str
{
	public partial class EnumerableOfPointD :IEnumerable<Point4dbl>
	{
		private IEnumerable<Point4dbl> _points;

		public IEnumerable<Point4dbl> points
		{
			get { return _points; }
			set { _points = value; }
		}
		
		public EnumerableOfPointD(IEnumerable<Point4dbl> points)
		{
			this.points = points;
		}

		public EnumerableOfPointD(
			params Point4dbl[] points	
		)
			:this(points as IEnumerable<Point4dbl>)
		{
		}

		
		static public EnumerableOfPointD Create(params Point4dbl[] points) {
			return new EnumerableOfPointD(points);
		}

		static public EnumerableOfPointD Create(IEnumerable<Point4dbl> points) {
			return new EnumerableOfPointD(points);
		
		}

		public IEnumerator<Point4dbl> GetEnumerator()
		{
			return _points.GetEnumerator();
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
