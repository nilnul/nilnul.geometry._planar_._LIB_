using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad
{
	static public class _ExtensionsX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Grad4dbl_byPointsI ToOpposite(this Grad4dbl_byPointsI grad) {
			return op_.Opposite.Unison.op(grad);
		}
	}
}
