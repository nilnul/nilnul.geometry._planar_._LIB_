using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.planar.line.be_.has_
{
	/// <summary>
	/// for y, x is to the right.
	/// </summary>
	static public class _ByAngleX
	{

		static public bool LineHasPoint(point.co_.Dif line, Point1 point)
		{

			if (point == line.component)
			{
				return true;

			}
			if (point == line.component1)
			{
				return true;

			}
			var x = new planar.point.trio.be_.steps.vow.Ee (

					line.component1
					,
					line.component
					,
					point
				).rotation();
			
			return x==0;

		}

	}
}
