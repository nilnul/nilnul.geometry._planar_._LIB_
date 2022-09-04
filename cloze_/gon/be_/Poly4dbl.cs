using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.geometry.planar.point.str_;
//using nilnul.geometry.planar.point.str_.started;
using nilnul.geometry.planar.sub_.directed_.connected_.gon;


namespace nilnul.geometry.planar.cloze_.gon.be_
{
	/// <summary>
	/// </summary>
	public class Poly4dbl
		:nilnul.geometry.planar.cloze_.gon.Be4dblI
	{
		public bool be(Polygon4dblI obj)
		{
			return obj.vertexes.Count()>=3;
		}

		static public Poly4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Poly4dbl>.Instance;
			}
		}


	}
}
