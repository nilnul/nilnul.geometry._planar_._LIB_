using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.trans_.affine_
{

	public interface IShiftOnly:IAffine
	{
	}

	public class Shift4dbl : Affine4dbl
	{
		public Shift4dbl( double translate) : base(1, translate)
		{
		}
	}
}
