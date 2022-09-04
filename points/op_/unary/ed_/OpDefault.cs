using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.geometry.planar.points.op_.unary.ed_
{
	

	public class OpDefault<TOp>
		: nilnul.obj.op_.unary.ed_.OpDefault<IEnumerable<Point4dbl>, TOp>
		where TOp : UnaryDblI, new()
	{
		public OpDefault(IEnumerable<Point4dbl> input) : base(input)
		{
		}
	}
}
