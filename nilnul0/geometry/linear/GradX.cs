using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear
{
	static public class GradX 
	{
		static public linear.Vector Vector(this Grad1 arg)
		{
			return new Vector(arg.Item2.ToClass() - arg.Item1);
		}

		static public linear.VectorDbl Vector(this GradDbl arg)
		{
			return new VectorDbl(arg.Item2.ToClass() - arg.Item1);
		}


	

	}
}
