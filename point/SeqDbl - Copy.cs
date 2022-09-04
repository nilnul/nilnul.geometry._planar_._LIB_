using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point
{
	public interface ISeqD
		: IEnumerable<Point4dbl>
	{
		
	}

	public class ListD : List<Point4dbl>
	{
		public ListD()
		{
		}

		public ListD(int capacity) : base(capacity)
		{
		}

		public ListD(IEnumerable<Point4dbl> collection) : base(collection)
		{
		}
	}
}
