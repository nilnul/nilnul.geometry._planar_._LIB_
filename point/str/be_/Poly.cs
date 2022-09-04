using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str.be_
{
	/// <summary>
	/// >=3 or >2.
	/// multi, many, a lot, numerous. Poly is chosen 'cuz it shares something with positive >0, plural>1
	/// </summary>
	public class Poly : Be4dblI
		,
		BeI1
	{ 
		public bool be(str_.SeqI obj)
		{
			return obj.Count() >=3;
			//throw new NotImplementedException();
		}

		public bool be(IEnumerable<Point4dblI> obj)
		{
			return  obj.Count() >=3;
		}

		public bool be(IEnumerable<PointI1> obj)
		{
			return obj.Count() >= 3;
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
