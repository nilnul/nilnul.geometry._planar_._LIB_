using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.real;

namespace nilnul.geometry.planar.vect.be_
{
	/// <summary>
	/// in first quadrant (including boundary)
	/// </summary>
	public class Positives: 
		vect.Be4dblI
	{
		

		public bool be(Vect4dblI obj)
		{
			return obj.point.x > 0 || obj.point.y > 0;
		}


		static public Positives Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Positives>.Instance;
			}
		}


	}
}
