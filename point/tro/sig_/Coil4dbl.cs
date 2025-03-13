using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.trio.sig_
{

	/// <summary>
	/// true:counterClock, false:clock, null: sameLine
	/// </summary>
	/// 
	public class Coil4dbl : nilnul.obj.SignI<TrioD>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>true:counterClock, false:clock, null: sameLine</returns>
		public bool? sign(TrioD obj)
		{
			return _Coil4dblX.Sig(obj.a,obj.b,obj.c);

		}
		public bool? sign(Point4dbl a, Point4dbl b, Point4dbl c)
		{
			return _Coil4dblX.Sig(a,b,c);

		}

		public bool? sign(Point4dblI a, Point4dblI b, Point4dblI c)
		{
			return _Coil4dblX.Sig(a,b,c);

		}




		static public Coil4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Coil4dbl>.Instance;
			}
		}


	}
}
