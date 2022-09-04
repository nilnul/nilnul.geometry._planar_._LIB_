using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.geometry.planar.trans
{
	public partial class Matrix
	{
		public Matrix(double a, double b, double c, double d, double e, double f)
		{


		}

		static public double[,] GenerateMatrix(double a00, double b01, double c02, double d10, double e11, double f12)
		{

			var raw = nilnul.num.real.matrix.square.Matrix.Ini(3);

			raw[0, 0] = a00;
			raw[0, 1] = b01;

			raw[0, 2] = c02;

			raw[1, 0] = d10;
			raw[1, 1] = e11;
			raw[1, 2] = f12;


			return raw;



		}
	
		

	
	}
}
