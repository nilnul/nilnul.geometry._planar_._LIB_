using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.polygon.vsPoint.has_
{
	/// <summary>
	/// ray casting,
	/// but when the ray intersects at the endpoint,
	///		winding number is computed as:
	///			if the edge points upwards, winding number increase
	///			otherwise, winding number decreases.
	///		thus:
	///			when the two edges are all underneath, the winding number is 0
	///			when both are pointing upwards, the winding number is 1
	///			when both pointing downards, the winding number is -1
	/// </summary>
	static public class RayWinding
	{

		public static bool? IsInPolygon(
			this Point4dbl testPoint
			,
			planar.zone_.Polygon4dbl polygon
		)
		{
			var r = false;

			/// the previous edge 
			var passThruEnd_edgeUpward = false;
			var passThruEnd_edgeDownward = false;

			#region pass thru start would be cancelled again passThruEnd; if not cancelled, this is left to the last edge that is not horizon.
			var firstThruStart_edgeDownward = false;
			var firstThruStart_edgeUpward = false;

			#endregion

			foreach (var grad in polygon.grads)
			{
				if (grad.basis.y < testPoint.y)
				{
					if (grad.finish.y < testPoint.y)
					{
						//continue;
					}
					else if (grad.finish.y == testPoint.y) /// grad pointing upwards
					{
						if (testPoint.x < grad.finish.x)
						{
							passThruEnd_edgeUpward = true; //  pass thru the endPoint
						}
						else if (testPoint.x == grad.finish.y)
						{
							return null;
						}
						else // testPoint is right to the grad.
						{
							//defer decision
						}
					}
					else ///finish.y > testPoint.y
						/// grad pointing upward.
					{
						//use multi.
						var lineIntersectedX = grad.basis.x + (testPoint.y - grad.basis.y) / (grad.finish.y - grad.basis.y) * (grad.finish.x - grad.basis.x);

						var multi = testPoint.x * (grad.finish.y - grad.basis.y);

						var intersectedMulti = grad.basis.x * (grad.finish.y - grad.basis.y)
							+
							(testPoint.y - grad.basis.y) * (grad.finish.x - grad.basis.x)
						;

						///todo: is the above the stokes area?
						/// it seems yes.
						///
						var stokes = coil_.gon._SurroundedX.Stokes(
							testPoint, grad.basis,grad.finish
						);

						if (multi < intersectedMulti)
						{
							r = !r;
						}
						else if (multi  == intersectedMulti)
						{
							return null;
						}
						else
						{
							//defer
						}

					}
				}
				else if (grad.basis.y == testPoint.y)
				{
					if (grad.finish.y < testPoint.y) /// grad pointing downward.
					{
						if (testPoint.x < grad.basis.x)
						{
							/// pass thru start.
							///
							if (passThruEnd_edgeUpward)
							{
								passThruEnd_edgeUpward = false;
								//cancelled.


							}
							else if (passThruEnd_edgeDownward) {
								r = !r;
								passThruEnd_edgeDownward = false;
							}
							else // this is the first grad.
							{
								firstThruStart_edgeDownward = true;
							}

						}
						else if (testPoint.x == grad.basis.x)
						{
							return null;
						}
						else /// testPoint.x > grad.basis.x 
						{
							//defer decision.
						}
					}
					else if (grad.finish.y == testPoint.y)
					{

						if (new geometry.linear.GradDbl(grad.basis.x, grad.finish.x).has(testPoint.x))
						{
							return null;
						}
						else
						{
							/// the adjacent edge pair would determine

						}
					}
					else /// grad.finish.y > testPoint.y
					{  /// grad from the ray,  points upwards
						if (testPoint.x < grad.basis.x)
						{
							//pass thru start.
							// so the previous grad must pass thru end.

							if (passThruEnd_edgeUpward)
							{
								r = !r;

							}
							else if(passThruEnd_edgeDownward) /// 
							{
								//do nothing
							}
							else  ///this is the first 
							{
								firstThruStart_edgeUpward = true;
							}
						}
						else if (testPoint.x == grad.basis.x)
						{
							return null;

						}
						else ///testPoint.x >=grad.bases.x
						{
							//do nothing. leave to the remaining edges.
						}
					}
				}
				else ///grad.basis.y > testPoint.y
				{
					if (grad.finish.y < testPoint.y)
					{
						var lineIntersectedX = grad.basis.x + (testPoint.y - grad.basis.y) / (grad.finish.y - grad.basis.y) * (grad.finish.x - grad.basis.x);

						if (testPoint.x < lineIntersectedX)
						{
							r = !r;
						}
						else if (testPoint.x == lineIntersectedX)
						{
							return null;
						}
						else
						{

						}
					}
					else if (grad.finish.y == testPoint.y)  ///grad pointing down
					{
						if (testPoint.x < grad.finish.x)
						{
							///pass thru finish
							///
							passThruEnd_edgeDownward = true;
						}
						else if (testPoint.x == grad.finish.x)
						{
							return null;
						}
						else
						{
							//defer decision.
						}
					}

				}
			}

			if (passThruEnd_edgeDownward)
			{
				if (firstThruStart_edgeDownward)
				{
					r = !r;
				}
			}
			else
			{
				if (firstThruStart_edgeUpward)
				{
					r = !r;
				}

			}

			return r;

		}



	}
}
