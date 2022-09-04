using nilnul.geometry.planar.cycle_.gon_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.facet_.gon.vsPoint.has_
{
	/// <summary>
	/// ray casting.
	/// Note there might be incident edges; 
	/// 
	/// </summary>
	static public class _ByWindingNumber
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="testPoint"></param>
		/// <param name="polygon"></param>
		/// <returns></returns>
		/// 
		public static bool? IsInPolygon(
			this Point4dblI testPoint
			,
			planar.facet_.Gon4dblI polygon
		)
		{
			var r = 0;	//note: in the proces this number can be 2 as it can pass the cut, then the enumeration of the next coil starts from other edge and now it's wound twice.
			// only later pass the cut in oppostive direction again, the winding number decreases to 1 again.

			/// the previous edge 
			var passThruEnd_edgeUpward = false;
			var passThruEnd_edgeDownward = false;

			#region pass thru start would be cancelled again passThruEnd; if not cancelled, this is left to the last edge that is not horizon.

			var firstThruStart_edgeDownward = false;
			var firstThruStart_edgeUpward = false;

			#endregion

			foreach (var grad in polygon.grads) /// in positive order, in adjacency.
			{
				var crossed = ray_.horizon_.increase.vsGrad._NearestJoint.NearestJoint(
					testPoint
					,
					grad
				);

				if (crossed is null)
				{
					continue; //see other grad
				}

				///crossed at some point.
				if (testPoint.x == crossed.Value)
				{
					return null;  //on the edge
				}

				///crossed at some distance.

				if (grad.basis.y == grad.finish.y)
				{
					continue;
				}

				if (grad.basis.y < grad.finish.y) //point upward
				{
					if (crossed.Value == grad.basis.x) //from ray
					{
						if (passThruEnd_edgeUpward)  // previous upward
						{
							r += 1;
							passThruEnd_edgeUpward = false;
						}
						else if (passThruEnd_edgeDownward)  //previous 
						{
							//passThruEnd_edgeDownward = false;
							continue;
						}
						else
						{
							firstThruStart_edgeUpward = true;
							//have to be considered consulting with the last enumerated grad.
							continue;
						}
					}
					else if (crossed.Value == grad.finish.x)
					{
						passThruEnd_edgeUpward = true;
						continue;
					}
					else
					{
						r += 1;
					}
					continue;
				}else
				if (grad.basis.y > grad.finish.y)  // downward
				{
					if (crossed.Value == grad.basis.x) //from ray
					{
						if (passThruEnd_edgeUpward)
						{
							continue;
						}
						else if (passThruEnd_edgeDownward)
						{
							r -= 1;
							continue;
						}
						else
						{
							firstThruStart_edgeDownward = true;
							//have to be considered consulting with the last enumerated grad.
							continue;
						}
					}
					else if (crossed.Value == grad.finish.x) // to ray
					{
						passThruEnd_edgeDownward = true;
						continue;

					}
					else
					{
						r -= 1;
						continue;
					}
					continue;
				}
			}

			if (passThruEnd_edgeDownward)
			{
				if (firstThruStart_edgeDownward)
				{
					r -= 1;
				}
				else
				if (firstThruStart_edgeUpward)
				{

				}
				else
				{
					throw new Exception(
						$"the ray crossed the last unhorizontal grad: {polygon.grads.Last()} at the end. but not thru the start of the first unhorizontal grad: {polygon.grads.First()}."
					);

				}

			}
			else if (passThruEnd_edgeUpward)
			{
				if (firstThruStart_edgeUpward)
				{
					r += 1;
				}
				else if (firstThruStart_edgeDownward)
				{

				}
				else
				{
					throw new Exception(
						$"the ray crossed the last unhorizontal grad: {polygon.grads.Last()} at the end, but not thru the start of the first unhorizontal grad: {polygon.grads.First()} "
					);
				}

			}
			else {
				if (firstThruStart_edgeDownward || firstThruStart_edgeUpward)
				{
					throw new Exception(
						$"the ray crossed the first unhorizontal grad: {polygon.grads.First()} , but not thru the last unhorizontal grad: {polygon.grads.Last()} "
					);

				}
				else
				{

				}

			}
			if (r<0)
			{
				throw new Exception(" winding number shall not be negative, as the polygon winds affirmatively.");
			}
			if (r>1)
			{
				throw new Exception(" winding number shall not be plural, as the polygon winds only once for any internal point.");

			}
			return r > 0;

		}





	}
}
