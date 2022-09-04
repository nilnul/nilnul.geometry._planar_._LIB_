using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.geometry.planar.points.op_.unary_.sort.ed_
{


	public class ByHorizon : op_.unary_.sort.EdDbl
	{

		public ByHorizon(IEnumerable<Point4dbl> input) : base(input,
			SortDbl.CreateByHorizon()

			)
		{
		}




	}

}
