using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point_.wai_
{
	
	public class Unital4dbl :
		
		Eks4dblI
	{
		public double x =>0;

		public double y => 1;


		static public Unital4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Unital4dbl>.Instance;
			}
		}

	}
}
