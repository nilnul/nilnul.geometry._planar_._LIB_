using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.gon
{
	static class _TwinX
	{

		/// <summary>
		/// twisted to the other side; like the clam's shell, we take the other side's orient (positiveness of surrounded ) as the opposite of current side's orientation;
		/// </summary>
		/// <param name=""></param>
		/// <returns></returns>
		static public IEnumerable<C> _Twin_0started(
			IEnumerable<C> gon
		) {
			return gon.Concat(gon);
		}
	}
}
