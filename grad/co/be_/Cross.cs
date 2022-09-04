using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.co.be_
{
	/// <summary>
	/// share at least one point
	/// </summary>
	public class Cross : BeI
	{
		public bool be(Co obj)
		{
			return be(obj.Item1,obj.Item2);
			//throw new NotImplementedException();
		}

		public bool be(point.Co x, point.Co y)
		{
			var xx_y1 = nilnul.geometry.planar.point.trio.sig_.Coil.Singleton.sign(x.component, x.component1, y.begin
			);

			var xx_y2 = nilnul.geometry.planar.point.trio.sig_.Coil.Singleton.sign(x.component, x.component1, y.begin
			);

			var yy_x1 = nilnul.geometry.planar.point.trio.sig_.Coil.Singleton.sign(y.begin, y.end, x.begin
			);

			var yy_x2 = nilnul.geometry.planar.point.trio.sig_.Coil.Singleton.sign(y.begin, y.end, x.begin
			);


			if (xx_y1 != xx_y2 && yy_x1 != yy_x2) return true;


			if (xx_y1 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._HasX._Has_ofColinear(x, y.begin))
			{
				return true;
			}
			if (xx_y2 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._HasX._Has_ofColinear(x, y.end))
			{
				return true;

			}
			if (yy_x1 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._HasX._Has_ofColinear(y, x.begin))
			{
				return true;

			}
			if (yy_x2 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._HasX._Has_ofColinear(y, x.end))
			{
				return true;

			}

			return false;
		}

		public bool be(GradI x, GradI y)
		{
			return be(x.points, y.points);

		}


		static public Cross Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Cross>.Instance;
			}
		}

	}
}
