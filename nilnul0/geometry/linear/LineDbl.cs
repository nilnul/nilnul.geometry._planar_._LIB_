using nilnul.geometry.linear.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.linear
{
	public  class Line4dbl:point.co.be_.dif.vow.Ee4dbl
		
	{


		public PointDblI point
		{
			get { return ee.component; }
		}




		public PointDblI point1
		{
			get { return ee.component1; }
		}

		

		public Line4dbl(point.CoDbl pair):base(pair) {



			
		}
		public Line4dbl(
			PointDblI point,
			PointDblI point1
		)
			:this(new point.CoDbl( point,point1))
		{
			

		}

		public Line4dbl(
			PointDbl point,
			PointDbl point1
		)
			:this((PointDblI) point, (PointDblI) point1)
		{
			

		}



	

		public Line4dbl(linear.grad_.Skid4dbl dir)
			:this(dir.component,dir.component1)
		
		{
			
		}

		


		/// <summary>
		/// this combinate can also be used in 3d, or 2d.
		/// </summary>
		/// <remarks>
		/// if the two points were the same, the linear combinate is a point.
		/// </remarks>
		/// <param name="x"></param>
		/// <returns></returns>
		public PointDbl combinated(
			double x
		) {
			return (1-x) * this.ee.Item1.ToImpl() +  x * this.ee.Item2.ToImpl();
			// this is infact basis + x* (point2 - point1). Note: point2-point1 is a 1d nonnil vector.
		}

	


	}
}
