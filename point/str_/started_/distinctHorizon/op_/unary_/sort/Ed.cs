using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.geometry.planar.points_.started_.distinctHorizon.op_.unary_.sort
{
	

		public class Ed : nilnul.obj.op_.unary.ed_.OpDefault<DistinctHorizonDbl, SortByHorizonDbl>
		{

			public Ed(DistinctHorizonDbl val):base(val)
			{

			}

			public Ed(IEnumerable<Point4dbl> input) : this(
				new DistinctHorizonDbl(input)
			)
			{
			}

			



		
	}
}
