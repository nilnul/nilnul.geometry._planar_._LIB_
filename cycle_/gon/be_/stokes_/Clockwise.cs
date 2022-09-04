using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon.be_.stokes_
{
	/// <summary>
	/// </summary>
	public class Positive :
		gon.Be4dblI
	{
		

		public bool be(Polygon4dbl obj)
		{
			return geometry.planar.cycle_.gon._StokesX.Stokes(obj)>0;
		}


		static public Positive Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Positive>.Instance;
			}
		}

	}
}
