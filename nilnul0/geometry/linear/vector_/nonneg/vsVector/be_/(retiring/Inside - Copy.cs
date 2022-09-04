using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect_.nonneg.as_.basis.of_.vector.be_
{

	[Obsolete()]
	static public class _InsideX
	{
		/// <summary>
		/// you cannot say vector is greater or lower as the base is non directional 
		/// </summary>
		/// <param name="v"></param>
		/// <returns></returns>
		static public bool _Be(Vector _nonneg, Vector p)
		{


			var vsZero = nilnul.num.real.Sign.Singleton.sign(p.x);


			var vsRight = nilnul.num.real.Comparer.Singleton.Compare(p.x, _nonneg.x);

			if (vsZero == false)
			{
				return false;
			}
			

			if (vsRight > 0)
			{
				return false;
			}
			return true;
			
		}
	}
}
