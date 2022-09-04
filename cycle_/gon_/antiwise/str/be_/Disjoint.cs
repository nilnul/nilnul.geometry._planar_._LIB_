using nilnul.obj.str.be_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon_.antiwise.str.be_
{
	public class Disjoint
		: str.Be4dblI
	{
		public bool _be_strAssumeDisjoint(IEnumerable<Antiwise4dbl> obj, Antiwise4dbl next)
		{

			return obj.All(
				p=> cycle_.gon.co.be_.Disjoint4dbl.Singleton.re( p,next)
			);

		}
		public bool be(IEnumerable<Antiwise4dbl> obj)
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
