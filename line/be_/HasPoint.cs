using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.point;
using nilnul.geometry.planar.point.co.be_.dif.vow;
using nilnul.num;

namespace nilnul.geometry.planar.line.be_
{
	/// <summary>
	/// for y, x is to the right. by area
	/// </summary>
	static public class HasPointX
	{
		public static bool _assumeDif(Point1 begin, Point1 end, Point1 point)
		{
			return  planar.coil_.gon._SurroundedX.Stokes(begin, end, point).ToReal()==0;
		}

		internal static bool Bit(Ee points, Point1 p)
		{
			return _assumeDif(points.ee.begin,points.ee.end,p);
		}

		public static bool _assumeDif(Twin en, Point1 point)
		{
			return _assumeDif(en.begin, en.end, point);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="edge"></param>
		/// <param name="point"></param>
		/// <returns></returns>
		static public bool Bit(point.co_.Dif edge, Point1 point) {
			return  _assumeDif(edge.ee.Item1, edge.ee.Item2, point);
		}
		static public bool Bit(tend_.Edge edge, Point1 point) {
			return _assumeDif(edge.en, point);

		}


	}
}
