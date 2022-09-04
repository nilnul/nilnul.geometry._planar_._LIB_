using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._transform_
{
	public interface LinearI
	{
		/// <summary>
		/// the transformation matrix is a 2x2 matrix
		/// </summary>
		nilnul.num.real.matrix_.square_.Two_Two matrix {
			get;

		}
	}
}
