using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect.as_.basis.of_.vector.be_._inside.by_
{
	
	static public class _CheckDirectionX
	{
		/// <summary>
		/// you cannot say vector is greater or lower as the base is non directional 
		/// </summary>
		/// <param name="v"></param>
		/// <returns></returns>
		static public bool Be(Vector vector, Vector p)
		{
			if (vector <0)
			{
				return linear.vect_.nonneg.as_.basis.of_.vector.be_._InsideX._Be(-vector, -p);
			}

			return linear.vect_.nonneg.as_.basis.of_.vector.be_._InsideX._Be(vector, p);
			
		}

		

	}
}
