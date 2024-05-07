using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.of_.binary_
{
	/*R^n里可以定义n-1个向量的叉乘，就是以标准基为第一行、n-1个向量为后面n-1行得到的n*n行列式展开后的结果，
		几何意义就是跟这n-1个向量垂直的、长度为它们张成的平行超多面体的体积的、方向与定向相符的一个向量
	
	 eg:
		for 2d vect:
			a+bi
		the matrix:
			1,i
			a,b
		the cross product:
			b-ia

	eg:
		for 1d vect:
			x
		the matrix
			1
		the cross product:
			1.
		
	eg:
		for 0d vect:
			()
		the matrix
			[]
		the cross product:
			1.
			
	 */
	/// <summary>
	/// 
	/// </summary>
	internal class CrossProduct
	{
	}
}
