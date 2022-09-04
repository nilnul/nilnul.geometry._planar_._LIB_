using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.vow
{
	[Obsolete(nameof(vect.vow.Ee4dbl))]
	public class EeDouble : EeDouble<planar.vect.VowDoubleI>
	{
		public EeDouble(Vector4dblI val, VowDoubleI vow) : base(val, vow)
		{
		}
	}
}
