using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon.be_.stokes_
{
	/// <summary>
	/// </summary>
	public class Neg :
		gon.Be4dblI
	{
		

		public bool be(Polygon4dbl obj)
		{
			return _StokesX.Stokes(obj)<0;
		}


		static public Neg Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Neg>.Instance;
			}
		}

		public bool _be_assumeCycle(List<Grad4dbl_byPointsI> contour)
		{
			return _StokesX._Stokes_assumeCycle(
				contour.Select(g=>g.basis)
			)<0;

		}
	}
}
