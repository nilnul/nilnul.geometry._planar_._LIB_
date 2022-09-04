using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.points_.started_.distinctHorizon_
{
	/// <summary>
	/// 
	/// </summary>
	public class SortedByHorizonDbl:distinctHorizon.op_.unary_.sort.Ed
	{
		public SortedByHorizonDbl(IEnumerable<Point4dbl> points):base(points)
		{

		}




		public double minAbscissa
		{
			get
			{
				return result.ee.First().x;

			}
		}

		public double maxAbscissa
		{
			get
			{
				return result.ee.Last().x;

			}
		}

		




	}
}
