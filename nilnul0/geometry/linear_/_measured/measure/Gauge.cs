using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._gauged
{
	public class Gauge4dbl<T>
		:

		_measured.Mark4dblA<T>
		where T : linear_._measured.Unit4dblI
	{
		public Gauge4dbl(double quantity0, T unit) : base(quantity0, unit)
		{
		}
	}

	public class Gauge4dbl
		:

		Gauge4dbl< _measured.Unit4dbl>
		
	{
		public Gauge4dbl(double quantity0) : base(quantity0, _measured.Unit4dbl.Singleton)
		{
		}
	}


}
