using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.trigonize
{
	/// <summary>
	/// extend the trigon to a parallelogram.
	///
	///  eg: for grad: (2,1) -> ( 1,2)
	///  ,then we would get trigon (0,0), (2,1), (1,2) 
	///  , then we would get parlgram  (0,0), (2,1) , (3,3), (1,2), which is a sweep :
	///			from grad: (0,0), (2,1)  to ( 1,2), (3,3)
	/// in general:(0,0), (x0,y0), (x0+x1,y0+y1), (x1,y1) 
	/// </summary>
	class IParallelogram
	{
	}
}
