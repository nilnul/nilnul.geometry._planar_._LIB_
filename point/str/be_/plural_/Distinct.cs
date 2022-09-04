using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str.be_.plural_
{
	/// <summary>
	/// </summary>
	public class Distinct :
		Be4dblI
		,
		BeI1
	{
		public bool be(IEnumerable<PointI1> obj)
		{
			
			return be_.Poly.Singleton.be(obj) && be_.Distinct.Singleton.be(obj);
			//throw new NotImplementedException();
		}




		public bool be(IEnumerable<Point4dblI> obj)
		{
			return be_.Plural.Singleton.be(obj)
				&&
				be_.Distinct.Singleton.be(obj);
			//throw new NotImplementedException();

		}


		static public Distinct Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Distinct>.Instance;
			}
		}


	}
}
