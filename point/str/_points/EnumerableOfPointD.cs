using nilnul.geometry._2d.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar._points
{
	public partial class EnumerableOfPointD
	{
		private IEnumerable<PointInDouble> _points;

		public IEnumerable<PointInDouble> points
		{
			get { return _points; }
			set { _points = value; }
		}
		
		public EnumerableOfPointD(IEnumerable<PointInDouble> points)
		{
			this.points = points;
		}

		public EnumerableOfPointD(
			params PointInDouble[] points	
		)
			:this(points as IEnumerable<PointInDouble>)
		{
		}

		public IEnumerable<_2d.dir.Dir> dirs {
			get {
				for (int i = 1,j=0; i < _points.Count(); i++,j++)
				{
					yield return _2d.dir.Dir.Create(_points.ElementAt(j), _points.ElementAt(i));
				}
			}
		}
		static public EnumerableOfPointD Create(params PointInDouble[] points) {
			return new EnumerableOfPointD(points);
		}

		static public EnumerableOfPointD Create(IEnumerable<PointInDouble> points) {
			return new EnumerableOfPointD(points);
		
		}

	}
}
