using nilnul.obj.str.be_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon.str.be_
{
	public class Disjoint
		: str.Be4dblI
	{
		public bool _be_strAssumeDisjoint(IEnumerable<Polygon4dblI> obj, Polygon4dblI next)
		{

			return obj.None(
				p=> zone_.gon.co.be_.Disjoint4dbl.Singleton.re( p,next)
			);

		}
		public bool be(IEnumerable<Polygon4dblI> obj)
		{
			if (obj.Any())
			{
				var skip1 = obj.Skip(1);
				return be(
					skip1
				)
				&&
				_be_strAssumeDisjoint(
						skip1
						,
						obj.First()
				);
			}
			return true;


		}


		static public Disjoint Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Disjoint>.Instance;
			}
		}


	}
}
