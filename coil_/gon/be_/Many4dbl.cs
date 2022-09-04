using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.geometry.planar.coil_.gon_.poly.be_;
using nilnul.geometry.planar.point.str_;
//using nilnul.geometry.planar.point.str_.started;
using nilnul.geometry.planar.sub_.directed_.connected_.gon;

namespace nilnul.geometry.planar.coil_.gon.be_
{
	/// <summary>
	/// 3 or more grads
	/// </summary>
	public class Many4dbl
		:
		coil_.gon.Be4dblI
	{
		
	
	

		public bool be(Gon4dblI obj)
		{
			return obj.vertexes.Skip(2).Any();
	

		}

		public bool be(IEnumerable<planar.Point4dblI> c)
		{
			return be(
				new coil_.Gon4dbl(c)
			);
			//throw new NotImplementedException();
		}

		static public Many4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Many4dbl>.Instance;
			}
		}

	}
}
