using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.trigonize.parlgrm
{
	/// <summary>
	/// for the eg in <see cref="trigonize.IParallelogram"/>
	///		,the grad: (2,1), (1,2)
	///		, the parlgrm is A(0,0),B(2,1), C(3,3),D(1,2)
	///	then the drag is: (0,0), (3,0), (3,3), (0,3)
	///
	/// in general:A(0,0), E(x0+x1,0), C(x0+x1,y0+y1), F(0,y0+y1)
	/// ,and the cross diagnal is: (x0+x1, 0), to (0, y0+y1), which is (0,0) to (x0+x1,y0+y1) flipped as (0,0) to -(x0+x1,y0+y1) and then translated as (x1+x2,0) to (0, y0+y1)
	/// 
	/// </summary>
	/// the area of the drag is (x0+x1)*(y0+y1)
	/// 
	internal class IDrag
	{
	}
}
