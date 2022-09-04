using nilnul.obj._str_;
using nilnul.obj.str_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.geometry.planar.point.str_.seq_
{
	public class Started:nilnul.obj.str_.seq_.Started2<PointI1>
		,
		planar.point.str_.SeqI
	{

		public Started(PointI1 head, IEnumerable<PointI1> tail)
			:base(head,tail)
		{

		}

		
	}
}
