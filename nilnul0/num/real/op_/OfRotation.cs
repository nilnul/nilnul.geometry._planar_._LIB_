using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.convert_
{
	public interface OfRotationI:nilnul.num.real.ConvertI
	{
		nilnul.num.RealI convert(
			nilnul.geometry.planar.RotationI1 rotation
		);
	}
}
