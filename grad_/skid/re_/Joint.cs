using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid.re_
{
	

	public class Joint : ReI
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		/// <seealso cref="nameof(grad.co.be_.Cross)"/>
		public bool re(IArrow x, IArrow y)
		{
			var xx_y1 = nilnul.geometry.planar.point.trio.sig_.Coil.Singleton.sign(
				x.points.ee.begin, x.points.ee.end, y.points.ee.begin
			);

			var xx_y2 = nilnul.geometry.planar.point.trio.sig_.Coil.Singleton.sign(x.points.ee.begin, x.points.ee.end, y.points.ee.begin
			);

			var yy_x1 = nilnul.geometry.planar.point.trio.sig_.Coil.Singleton.sign(y.points.ee.begin, y.points.ee.end, x.points.ee.begin
			);

			var yy_x2 = nilnul.geometry.planar.point.trio.sig_.Coil.Singleton.sign(y.points.ee.begin, y.points.ee.end, x.points.ee.begin
			);


			if (xx_y1 != xx_y2 && yy_x1 != yy_x2) return true;


			if (xx_y1 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._HasX._Has_ofColinear(x.points, y.points.ee.begin))
			{
				return true;
			}
			if (xx_y2 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._HasX._Has_ofColinear(x.points, y.points.ee.end))
			{
				return true;

			}
			if (yy_x1 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._HasX._Has_ofColinear(y.points, x.points.ee.begin))
			{
				return true;

			}
			if (yy_x2 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._HasX._Has_ofColinear(y, x.points.ee.end))
			{
				return true;

			}

			return false;
		}


		static public Joint Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Joint>.Instance;
			}
		}

	}
}
