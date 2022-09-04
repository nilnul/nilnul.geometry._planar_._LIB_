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
	public class Joint4dbl1 : Re4dblI
	{
		public bool _re_assumeSkids(Grad4dbl_byPointsI x, Grad4dbl_byPointsI y)
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

			/// the joint is only possible if the four points are colinear.
			/// we test each point

			if (xx_y1 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._Has4DblX._Has_assumeColine(x, y.basis))
			{
				return true;
			}
			if (xx_y2 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._Has4DblX._Has_assumeColine(x, y.finish))
			{
				return true;

			}
			if (yy_x1 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._Has4DblX._Has_assumeColine(y, x.basis))
			{
				return true;

			}
			if (yy_x2 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._Has4DblX._Has_assumeColine(y, x.finish))
			{
				return true;

			}

			return false;
		}

		public bool re_assumeSteps(Grad4dbl_byPoints x, Grad4dbl_byPoints y)
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


			if (xx_y1 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._Has4DblX._Has_assumeColine(x, y.basis))
			{
				return true;
			}
			if (xx_y2 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._Has4DblX._Has_assumeColine(x, y.finish))
			{
				return true;

			}
			if (yy_x1 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._Has4DblX._Has_assumeColine(y, x.basis))
			{
				return true;

			}
			if (yy_x2 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._Has4DblX._Has_assumeColine(y, x.finish))
			{
				return true;

			}

			return false;
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


			if (xx_y1 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._Has4DblX._Has_assumeColine(x, y.basis))
			{
				return true;
			}
			if (xx_y2 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._Has4DblX._Has_assumeColine(x, y.finish))
			{
				return true;

			}
			if (yy_x1 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._Has4DblX._Has_assumeColine(y, x.basis))
			{
				return true;

			}
			if (yy_x2 == null && nilnul.geometry.planar.tend.vsPoint_.coline.be_._Has4DblX._Has_assumeColine(y, x.finish))
			{
				return true;

			}

			return false;
		}


		static public Joint4dbl1 Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Joint4dbl1>.Instance;
			}
		}


	}
}
