using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.unneg.tro.be_
{
	static public class _TrigonX
	{
		static public bool _Be_012unneg(double x, double y, double z) {
			var sum = nilnul.num.real.str._SumX.Sum(x, y, z)/2;// x + y + z;
			return ( (IEnumerable<double>) [x, y, z] ).All(t => t < sum);// x < sum && y < sum && z < sum;
			
		}
	}
}
