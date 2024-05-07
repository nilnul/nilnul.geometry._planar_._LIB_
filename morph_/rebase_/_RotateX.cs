using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.rebase_
{
	static public class _RotateX
	{
		/// <summary>
		/// Mx=y, where x is a vect.
		/// 
		/// </summary>
		/// <param name="rotation"></param>
		/// <returns></returns>
		static public double[,] GenCols_0rotation(double rotation) {
			double sin = Math.Sin(rotation);
			double cos = Math.Cos(rotation);
			return new[,] {
				{cos,-sin }
				,
				{ sin,cos}
			}; 
		}

		/// <summary>
		/// xM=y, where x is a vect.
		/// 
		/// </summary>
		static public double[,] GenRows_0rotation(double rotation) {
			double sin = Math.Sin(rotation);
			double cos = Math.Cos(rotation);
			return new[,] {
				{cos,sin }
				,
				{- sin,cos}
			}; 
		}


	}
}
