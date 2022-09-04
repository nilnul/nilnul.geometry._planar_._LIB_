using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
using nilnul.obj.op_;

namespace nilnul.geometry.planar.points.op_.unary
{
	public class EdDbl
		: nilnul.obj.op_.unary.Ed<IEnumerable<Point4dbl>>
		
	{
		public EdDbl(IEnumerable<Point4dbl> input,points.op_.UnaryDblI op) : base(input, op)
		{
		}

		public EdDbl(IEnumerable<Point4dbl> input, UnaryI<IEnumerable<Point4dbl>> op) : base(input, op)
		{
		}
	}

	
}
