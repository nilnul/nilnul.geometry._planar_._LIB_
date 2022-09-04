using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.trans_.affine_
{

	public interface IScaleOnly:IAffine
	{
	}
	public class Scale4dbl : trans_.Affine4dbl
	{
		public Scale4dbl(double scale) : base(scale, 0)
		{
		}
	}
}
