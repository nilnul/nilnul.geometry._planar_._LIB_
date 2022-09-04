﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect_.nonneg_.nil.as_.basis.of_.vector.be_
{
	
	static public class _InsideX
	{
		/// <summary>
		/// you cannot say vector is greater or lower as the base is non directional 
		/// </summary>
		/// <param name="v"></param>
		/// <returns></returns>
		static public bool Inside(Vector v)
		{
			return v == 0;
		}
	}
}