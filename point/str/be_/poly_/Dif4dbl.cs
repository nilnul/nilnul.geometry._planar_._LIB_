using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str.be_.poly_
{
	/// <summary>
	/// distinct
	/// </summary>
	public class Dif4dbl :
		Be4dblI
	{
		

		public bool be(IEnumerable<Point4dblI> obj)
		{
			return be_.Poly.Singleton.be(obj)
				&&
				be_.Distinct.Singleton.be(obj);
			//throw new NotImplementedException();

		}

		static public Dif4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Dif4dbl>.Instance;
			}
		}


	}
}
