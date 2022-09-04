using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.planar.span_.edge.duo.be_
{
	public class Cross : BeI
	{
		public bool be(Duo obj)
		{
			// special cases
			var abc = nilnul.geometry.planar.point.trio.sig_.Orient.Singleton.sign(x.points.begin, x.points.end, y.points.begin
				
			);





			int o2 = orientation(p1, q1, q2);
			int o3 = orientation(p2, q2, p1);
			int o4 = orientation(p2, q2, q1);

			throw new NotImplementedException();
		}

		public bool be(EdgeI x, EdgeI y)
		{


			// special cases

			var xx_y1 = nilnul.geometry.planar.point.trio.sig_.Orient.Singleton.sign(x.pair.en.begin, x.pair.en.end, y.pair.en.begin
			);


			var xx_y2 = nilnul.geometry.planar.point.trio.sig_.Orient.Singleton.sign(x.pair.en.begin, x.pair.en.end,  y.pair.en.begin
			);


			var yy_x1 = nilnul.geometry.planar.point.trio.sig_.Orient.Singleton.sign(y.pair.en.begin, y.pair.en.end, x.pair.en.begin
			);


			var yy_x2 = nilnul.geometry.planar.point.trio.sig_.Orient.Singleton.sign(y.pair.en.begin, y.pair.en.end,  x.pair.en.begin
			);
			if (xx_y1 ==false)
			{
				//xx is edge
				if (xx_y2==false)
				{
					return false;

				}
				if (xx_y2==null)
				{// y2 on the line of xx
					/// the three points are colinear
					///		and xx is edge
					/// 
					if (yy_x1 ==false)
					{
						//check the three points
						if (yy_x2==false)
						{
							return false;
						}
						if (yy_x2 == null)
						{
							return true;
						}
						return true;
					}
					if (yy_x1==null)
					{// x1 is colinear with yy
						if (yy_x2==false)
						{
							return true;

						}
						if (yy_x2==null)
						{// x2 is colinear with yy
						 //x1, x2 is on the line of yy
							throw new UnexpectedReachException();
						}
						if (yy_x2 == true)
						{// 
							return true;

						}
					}
					// true
					if (yy_x2 == false)
					{
						return true;
					}
					if (yy_x2 == null )
					{
						return true;
					}

					return false;

				}

				
			}
			if (xx_y1 == null)
			{

				switch (xx_y2)
				{
					case true:

						break;
					case null:
						break;
					default:
						break;
				}
			}
			//one true , one false

			if (yy_x1 ==false)
			{
				if (yy_x2==false)
				{
					return false;
				}
				if (yy_x2 == null)
				{

				}
				if (yy_x2==true)
				{
					return true;
				}

			}







			int o2 = orientation(p1, q1, q2);
			int o3 = orientation(p2, q2, p1);
			int o4 = orientation(p2, q2, q1);

			throw new NotImplementedException();
		}

	}
}
