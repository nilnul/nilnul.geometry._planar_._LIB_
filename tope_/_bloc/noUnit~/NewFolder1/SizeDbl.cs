using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rect
{

	static public class _SizeX
	{
		static public _size.WidthHeightDbl Size(nilnul.geometry.planar.PointDbl x) {
			return  _size.WidthHeightDbl.CreateByAbs(
				x.x
				,

				x.y);
		}

		static public _size.WidthHeightDbl Size(nilnul.geometry.planar.IVectorDbl x) {
			return Size(x.point);
		}





	}

}
