using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str_.seq.be_.poly_
{
	/// <summary>
	/// </summary>
	public class Dif :
		BeI
	{
		public bool be(str_.SeqI obj)
		{
			return be_.Poly.Singleton.be(obj) && be_.Distinct.Singleton.be(obj);
			//throw new NotImplementedException();
		}


		static public Dif Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Dif>.Instance;
			}
		}

	}
}
