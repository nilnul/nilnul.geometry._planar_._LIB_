using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point_.eks_
{
	
	public class Unital4dbl :
		
		Eks4dblI
	{
		public double x =>1;

		public double y => 0;


		static public Unital4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Unital4dbl>.Instance;
			}
		}

	}
}
