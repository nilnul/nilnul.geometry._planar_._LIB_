using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon.vsPoint.has_.byRay_.byWinding_
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
	static public class _StokesIfIntersected
	{

		public static bool? IsInPolygon(
			this Point4dbl testPoint
			,
			planar.zone_.Polygon4dbl polygon
		)
		{
			var winding = 0;

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
							winding += 1;
						}
						else if (testPoint.x == grad.finish.y)
						{
							return null;
						}
						else // testPoint is right to the grad.finish.
						{
							//defer decision
						}
					}
					else ///finish.y > testPoint.y
						/// grad pointing upward.
					{
						
						///
						var stokes = coil_.gon._SurroundedX.Stokes(
							testPoint, grad.basis,grad.finish
						);

						if (stokes >0)
						{

							winding += 1;
						}
						else if (stokes ==0)
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
					if (grad.finish.y < testPoint.y) /// grad, from baseline, pointing downward.
					{
						if (testPoint.x < grad.basis.x)
						{
							/// pass thru start.
							///
							if (passThruEnd_edgeUpward)
							{
								passThruEnd_edgeUpward = false;
								winding -= 1;
								//cancelled.
							}
							else if (passThruEnd_edgeDownward) {
								//winding += 1;
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
								//as alread is done in prev edge end, do nothing.
								passThruEnd_edgeUpward = false;

							}
							else if(passThruEnd_edgeDownward) /// 
							{
								//do nothing
								winding += 1;
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
					if (grad.finish.y < testPoint.y)//point downward
					{
						var stokes = coil_.gon._SurroundedX.Stokes(
							testPoint, grad.basis,grad.finish
						);

						if (stokes <0 )
						{
							winding -= 1;
						}
						else if (stokes ==0)
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
							winding -= 1;
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

				}
				else if(firstThruStart_edgeUpward)
				{
					winding += 1;
				}
			}
			else if(passThruEnd_edgeUpward)
			{
				if (firstThruStart_edgeUpward)
				{

				}
				else if(firstThruStart_edgeDownward)
				{
					winding -= 1;
				}

			}
			else
			{

			}

			return winding>=0;

		}



	}
}
