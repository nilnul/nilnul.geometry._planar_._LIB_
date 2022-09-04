using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid.re_
{

	/// <summary>
	/// joint. share at least one point.
	/// </summary>
	public class Joint4dbl : Re4dblI
	{
		public bool _re_assumeSkids(Grad4dbl_byPointsI x, Grad4dbl_byPointsI y)
		{
			var xx_y1 = nilnul.geometry.planar.point.trio.sig_.Coil4dbl.Singleton.sign(
	x.basis, x.finish, y.basis
);

			var xx_y2 = nilnul.geometry.planar.point.trio.sig_.Coil4dbl.Singleton.sign(x.basis, x.finish, y.finish
			);

			var yy_x1 = nilnul.geometry.planar.point.trio.sig_.Coil4dbl.Singleton.sign(y.basis, y.finish, x.basis
			);

			var yy_x2 = nilnul.geometry.planar.point.trio.sig_.Coil4dbl.Singleton.sign(y.basis, y.finish, x.finish
			);
			/// inline or not
			///
			if (xx_y1 is null)
			{
				if (xx_y2 is null)//inline
				{
					return skid.co_.coline.be_.Joint4dbl.Singleton._re_assumeSkidsAlign(
						x, y
					);
				}
			}

			return (xx_y1 != xx_y2 && yy_x1 != yy_x2);

		}

		public  bool _re_assumeSkids((Grad4dbl_byPointsI , Grad4dbl_byPointsI ) c)
		{

			return _re_assumeSkids(
				c.Item1
				,
				c.Item2
			);
		}

		public bool _re_assumeSkids(Grad4dbl_byPoints x, Grad4dbl_byPoints y)
		{
			return _re_assumeSkids(
				(Grad4dbl_byPointsI)x
				,
				(Grad4dbl_byPointsI)y

			);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		/// <seealso cref="nameof(grad.co.be_.Cross)"/>
		public bool re(Skid4dblI x, Skid4dblI y)
		{
			return _re_assumeSkids(x, y);

	
		}


		static public Joint4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Joint4dbl>.Instance;
			}
		}


	}
}
