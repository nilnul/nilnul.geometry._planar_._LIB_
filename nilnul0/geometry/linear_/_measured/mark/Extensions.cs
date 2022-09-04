using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.mark
{
	static public class ExtensionsX
		
	{
		

		static public double ToStd<T>(this Mark4dblI<T> x)
		where T : nilnul.obj._measure.Unit4dblI

		{
			return x.quantity * x.unit.magnitude.dblen.ee;
		}

		



	}
}
