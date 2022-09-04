using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.s.headed
{

	public class Area
	{

		static public double Eval(b.Headed.Asserted headed) {

			return headed.Connectors().Select(x => x.integral()).Sum();


		}
	}
}
