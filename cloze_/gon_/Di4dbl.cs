using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.cloze_.gon_
{
	/// <summary>
	/// it's important to include this, as, for example, <see cref="nameof(cloze_.poly_.arrow_.perspect_.Smallward)"/>, containing a digon, is regarded as polygon.
	/// </summary>
	/// the two points might be the same. So this is placed under <see cref="cloze_.gon_"/>, rather than <see cref="planar.coil_.IGon"/>
	public  class Di4dbl
		:_gon_.Vertexes4dblI
	{
		private planar.Point4dbl _start;

		public planar.Point4dbl  start
		{
			get { return _start; }
			set { _start = value; }
		}
		private planar.Point4dbl _end;

		public planar.Point4dbl end
		{
			get { return _end; }
			set { _end = value; }
		}

		public IEnumerable<Point4dblI> vertexes =>  new[] { _start,_end};

		public Di4dbl(planar.Point4dbl p, planar.Point4dbl p1)
		{
			this.start = p;
			this.end = p1;

		}
	}
}
