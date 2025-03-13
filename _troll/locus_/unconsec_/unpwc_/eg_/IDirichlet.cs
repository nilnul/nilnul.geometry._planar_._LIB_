using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._troll.locus_.unconsec_.unpwc_.eg_
{
	/// <summary>
	/// 
	/// </summary>
    class IDirichlet
    {
    }

	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// nowhere continuous:
	///		for any point t, no matter what δ we choose we can always find a z within δ of y=f(t), and f(z)  is at least 1⁄2 away from y
	/// </remarks>
	class Dirichlet
		///: _troll_.Fn4dblI
	{
		public C locus(nilnul.num.RealI time)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(time))
			{
				return 1;// new System.Numerics.Complex(1, 0);
			}
			return 0;
			//throw new NotImplementedException();
		}
	}
}
