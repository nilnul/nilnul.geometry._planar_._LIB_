using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.affine_.nontranslate_.reflect_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _UpwardX
	{
		static public double[,] Matrix = new double[,]{
			{ 1,0,0}
			,
			{0,-1 ,0}
			,
			{0,0,1 }

		};

		static public System.Drawing.Drawing2D.Matrix Matrix8float = new System.Drawing.Drawing2D.Matrix(
			1, 0, 0,- 1, 0, 0
		);

	}

}
