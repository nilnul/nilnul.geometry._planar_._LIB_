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
		static public bool _Be_0cycle(IEnumerable<Point4dblI> vertexes) {
			return geometry.planar.cycle_.gon._StokesX._Stokes_assumeCycle(vertexes)>0;
		}

		public static bool _Be_0cycle(IEnumerable<Grad4dbl_byPointsI> c)
		{
			return geometry.planar.cycle_.gon._StokesX._Stokes_0cycle(c)>0;

		}
		

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
