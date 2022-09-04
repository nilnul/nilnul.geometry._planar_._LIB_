using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.point
{
	public  class Seq
	{
		private IEnumerable<Point4dbl> _points;

		public IEnumerable<Point4dbl> points
		{
			get { return _points; }
			set { _points = value; }
		}
		
		public Seq(IEnumerable<Point4dbl> points)
		{
			this.points = points;
		}

		public Seq(
			params Point4dbl[] points	
		)
			:this(points as IEnumerable<Point4dbl>)
		{
		}

		public IEnumerable<planar.grad_.Step4dbl> dirs {
			get {
				for (int i = 1,j=0; i < _points.Count(); i++,j++)
				{
					yield return new grad_.Step4dbl(_points.ElementAt(j), _points.ElementAt(i));
				}
			}
		}
		static public Seq Create(params Point4dbl[] points) {
			return new Seq(points);
		}

		static public Seq Create(IEnumerable<Point4dbl> points) {
			return new Seq(points);
		
		}

	}
}
