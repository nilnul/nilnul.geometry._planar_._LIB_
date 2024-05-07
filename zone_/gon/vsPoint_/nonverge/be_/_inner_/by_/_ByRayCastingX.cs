using nilnul.geometry.planar.cycle_.gon_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon.vsPoint_.nonverge.be_._inner_.by_
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
	/// <see cref="cycle_.gon_.facade.vsPoint.sign_._PointInsidePolygon"/>
	/// <see cref="zone_.gon.vsPoint.has_.byRay_._StokesIfIntersected"/>
	static public class _ByRayCastingX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="testPoint"></param>
		/// <param name="zone">
		///a zone
		/// </param>
		/// <returns></returns>
		public static bool _HasAsInner_0zone_1nonverge(
			this IEnumerable<Point4dblI> zone
			,
			 Point4dblI testPoint
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

			foreach (var grad in nilnul.geometry.planar.cloze_.gon._Grads4dblX._Grads_ofStarted( zone) )
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
						else // testPoint is right to the grad.finish.
						{
							//defer decision
						}
					}
					else ///finish.y > testPoint.y
						 /// grad pointing maxward.
					{

						///
						var stokes = coil_.gon._SurroundedX.Stokes(
							testPoint, grad.basis, grad.finish
						);

						 if (stokes > 0)
						{

							r = !r;
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
							else if (passThruEnd_edgeDownward)
							{
								r = !r;
								passThruEnd_edgeDownward = false;
							}
							else // this is the first grad.
							{
								firstThruStart_edgeDownward = true;
							}

						}
						else /// testPoint.x > grad.basis.x 
						{
							//defer decision.
						}
					}
					else if (grad.finish.y == testPoint.y)
					{

							/// the adjacent edge pair would determine

	
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
							else if (passThruEnd_edgeDownward) /// 
							{
								//do nothing
							}
							else  ///this is the first 
							{
								firstThruStart_edgeUpward = true;
							}
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
							testPoint, grad.basis, grad.finish
						);

						if (stokes < 0)
						{
							r = !r;
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
				if (passThruEnd_edgeUpward)
				{
					if (firstThruStart_edgeUpward)
					{
						r = !r;
					}

				}

			}

			return r;

		}


		public static bool _HasAsInner_1nonverge(
			this planar.zone_.Polygon4dblI polygon
			,
			 Point4dblI testPoint
		)
		{
			return _HasAsInner_0zone_1nonverge(polygon.vertexes,testPoint);

		}

		public static bool _HasAsInner_1nonverge(
			TriangleDbl triangleDbl
			,
			Point4dblI x
		)
		{
			return _HasAsInner_1nonverge(
				(zone_.Polygon4dblI)triangleDbl
				,
				x
			);
			//throw new NotImplementedException();
		}

		public static bool _HasAsInner_1nonverge(
			zone_.Polygon4dbl_onPositiveCycle polygon
			,
			Point4dblI testPoint
		)
		{
			return _HasAsInner_1nonverge(
				(zone_.Polygon4dblI)(polygon)
				,
				testPoint
			);
			//throw new NotImplementedException();
		}

		public static bool _HasAsInner_1nonverge(
			Facade4dbl polygon
			,
			Point4dblI testPoint
			)
		{
			return _HasAsInner_1nonverge(
				new zone_.Polygon4dbl_onPositiveCycle(polygon)
				,
				testPoint
			);
			//throw new NotImplementedException();
		}

		public static bool _HasAsInner_1nonverge(
		this	planar.zone_.Polygon4dbl polygon
			,

			 Point4dbl testPoint
		)
		{
			return _HasAsInner_1nonverge(
				(Polygon4dblI)polygon
				,
				(Point4dblI)testPoint
			);
		}


	}
}
