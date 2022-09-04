using nilnul.obj.str_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str_
{
	public class Started4dbl
		: nilnul.obj.str_.Started5<Point4dblI>
	{
		public Started4dbl(IEnumerable<Point4dblI> seq) : base(seq)
		{
		}

		public Started4dbl(Point4dblI head, SeqI2<Point4dblI> tail) : base(head, tail)
		{
		}

		public Started4dbl(Point4dblI head, SeqI3<Point4dblI> tail) : base(head, tail)
		{
		}

		public Started4dbl(Point4dblI head, IEnumerable<Point4dblI> tail) : base(head, tail)
		{
		}
	}
}
