using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.drawable._morph_
{
	public interface OfPoint4DblI
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="original"></param>
		/// <returns></returns>
		planar.Point4dblI morph(planar.Point4dblI original);
	}
}
