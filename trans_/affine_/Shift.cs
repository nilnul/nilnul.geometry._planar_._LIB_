using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trans_
{

	/// <summary>
	/// extension of 1d Shift to the two axis respectively.
	/// </summary>
	public interface IShift :
		IIndepend
		,

		affine_.ITranslateOnly
		,
		trans_.IRigid
	{ }
	public class _ShiftX
	{
		static public (double, double) Trans(
			(double, double) coord2trans
	
			,
			(double,double) shift_2x1
		)
		{
			return
				(coord2trans.Item1+shift_2x1.Item1, coord2trans.Item2+shift_2x1.Item2)
				;

		}

		static public (double, double) Trans(
			(double, double) coord2trans
	
			,
			double[] shift_2x1
		)
		{
			return
				Trans(coord2trans, (shift_2x1[0],shift_2x1[1]))
				;

		}


	}
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	public class Shift
	{

		static public double[,] CreateMatrixFroNewOrigin(double x, double y) {

			return CreateMatrixFroNewOrigin(new Point4dbl(x,y));
		}

		static public double[,] CreateMatrixFroNewOrigin(Point4dbl newOrigin) {

			return CreateMatrix(
				-newOrigin.x
				,
				-newOrigin.y
			);
		}


		static public double[,] CreateMatrix(double tX, double tY) {

			return new double[,] {
				{1,0,tX}
				,
				{ 0,1,tY}
				,
				{ 0,0,1}
			};
		}
	}



}
