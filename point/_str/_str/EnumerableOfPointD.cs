using nilnul.geometry._2d.point;
using nilnul.geometry.planar._point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.geometry.planar._point.pointD._str
{
	public partial class EnumerableOfPointD :IEnumerable<PointD>
	{
		private IEnumerable<PointD> _points;

		public IEnumerable<PointD> points
		{
			get { return _points; }
			set { _points = value; }
		}
		
		public EnumerableOfPointD(IEnumerable<PointD> points)
		{
			this.points = points;
		}

		public EnumerableOfPointD(
			params PointD[] points	
		)
			:this(points as IEnumerable<PointD>)
		{
		}

		
		static public EnumerableOfPointD Create(params PointD[] points) {
			return new EnumerableOfPointD(points);
		}

		static public EnumerableOfPointD Create(IEnumerable<PointD> points) {
			return new EnumerableOfPointD(points);
		
		}

		public IEnumerator<PointD> GetEnumerator()
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
