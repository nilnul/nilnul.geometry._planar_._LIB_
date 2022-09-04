using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.geometry.planar.point.str_;
//using nilnul.geometry.planar.point.str_.started;
using nilnul.geometry.planar.sub_.directed_.connected_.gon;


namespace nilnul.geometry.planar.cloze_.gon.be_.poly_
{
	/// <summary>
	/// </summary>
	public class Skids4dbl
		:nilnul.geometry.planar.cloze_.gon.Be4dblI
	{
		
	
		public bool be(Polygon4dblI obj)
		{
			return be_.Poly4dbl.Singleton.be(obj) && obj.grads.All(
				g=> planar.grad.be_.Skid4dbl.Singleton.be(g)
			);
		}


		static public Skids4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Skids4dbl>.Instance;
			}
		}


	}
}
