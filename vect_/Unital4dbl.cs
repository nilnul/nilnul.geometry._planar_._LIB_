using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.vect.be_.unital.vow;
using nilnul.num;

namespace nilnul.geometry.planar.vect_
{
	public class Unital4dbl : vect.be_.unital.vow.Ee4dbl
		,
		Unital4dblI
	{
		public Unital4dbl(Vect4dblI val) : base(val)
		{
		}

		public Ee4dbl vectUnital =>this;

		public Point4dblI point => ee.point;
	}
}
