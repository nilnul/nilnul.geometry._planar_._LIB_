using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon.be_
{
	public class Quadri
		:
		zone_.gon.Be4dblI
	{
		public bool be(Polygon4dblI obj)
		{
			return obj.vertexes.Count() == 4;
		}

		static public Quadri Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Quadri>.Instance;
			}
		}
	}
}
