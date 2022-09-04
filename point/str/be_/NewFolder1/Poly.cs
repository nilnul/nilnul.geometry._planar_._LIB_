using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str_.seq.be_
{
	/// <summary>
	/// >=3 or >2.
	/// multi, many, a lot, numerous. Poly is chosen 'cuz it shares something with positive >0, plural>1
	/// </summary>
	///
	[Obsolete(nameof(point.str.be_.Poly))]
	public class Poly : BeI
	{
		public bool be(str_.SeqI obj)
		{
			return obj.Count() > 2;
			//throw new NotImplementedException();
		}



		static public Poly Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Poly>.Instance;
			}
		}


	}
}
