using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str_
{
	public class SeqDbl
		: nilnul.obj.str_.Seq2<planar.Point4dbl>
		,
		planar.point.StrDblI
		,SeqDblI
	{
		public SeqDbl(IEnumerable<Point4dbl> boxed) : base(boxed)
		{
		}

	
	}
}
