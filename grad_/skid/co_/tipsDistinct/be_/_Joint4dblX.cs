using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid.co_.tipsDistinct.be_
{
	
	/// <summary>
	/// there is a shared point.
	/// 
	/// </summary>
	static public class _Joint4dblX 
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		/// <seealso cref="nameof(grad.co.be_.Cross)"/>
		static public bool Re_assumeTipsDistinct(Skid4dblI x, Skid4dblI y)
		{
			var xx_y1 = nilnul.geometry.planar.point.trio.sig_.Coil4dbl.Singleton.sign(
				x.basis, x.finish, y.basis
			);

			var xx_y2 = nilnul.geometry.planar.point.trio.sig_.Coil4dbl.Singleton.sign(x.basis, x.finish, y.basis
			);

			var yy_x1 = nilnul.geometry.planar.point.trio.sig_.Coil4dbl.Singleton.sign(y.basis, y.finish, x.basis
			);

			var yy_x2 = nilnul.geometry.planar.point.trio.sig_.Coil4dbl.Singleton.sign(y.basis, y.finish, x.basis
			);


			if (xx_y1 != xx_y2 && yy_x1 != yy_x2) return true;


			if (xx_y1 is null
				&& nilnul.geometry.planar.tend.vsPoint_.coline.be_._Has4DblX._Has_assumeColine(x, y.basis
				)
			)
			{
				return true;
			}
			if (
				xx_y2 is null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._Has4DblX._Has_assumeColine(x, y.finish))
			{
				return true;

			}
			if (yy_x1 is null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._Has4DblX._Has_assumeColine(y, x.basis))
			{
				return true;

			}
			if (yy_x2 is null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._Has4DblX._Has_assumeColine(y, x.finish))
			{
				return true;

			}

			return false;
		}



	}
}
