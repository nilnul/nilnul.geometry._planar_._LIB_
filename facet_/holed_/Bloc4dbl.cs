using nilnul.geometry.planar.curve_.cloze_.circ_;
using nilnul.geometry.planar.loop_.circ_;
using nilnul.geometry.planar.vect_.nonnil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.facet_.holed_
{
	/// <summary>
	/// one circle in a bloc
	/// </summary>
	///
	[Obsolete("rename to be under:holed")]
	public class Bloc4dbl
		:
		drawable.draw_._svg_.ElI
	{
		private zone_.bloc_.Originated4dbl _bloc;

		public zone_.bloc_.Originated4dbl bloc
		{
			get { return _bloc; }
			set { _bloc = value; }
		}

		private loop_.circ_.Nontrivia4dbl _hole;

		public loop_.circ_.Nontrivia4dbl hole
		{
			get { return _hole; }
			set { _hole = value; }
		}

		public Bloc4dbl(
			zone_.bloc_.Originated4dbl bloc
			,
			Nontrivia4dbl hole
		)
		{
			var boundingOfCirc = hole.bounds;

			nilnul.bit.vow_.true_.Unacceptable.Singleton.vow(
				tope_.bloc.re_.sup_.Proper4dbl.Singleton.re(
					bloc
					,
					boundingOfCirc
				)
			);

			this._bloc = bloc;
			this._hole = hole;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_countOfArcs_plural">
		/// the caller need to keep this in order to know how many the first part of vertexes are for the circle, and how many remained for the middle point of an edge of outer bloc and the corners of the outer bloc.
		/// </param>
		/// <returns>
		/// cannot use <see cref="coil_.Polygon4dbl"/>, as there are one edge (two points) used twice.
		/// </returns>
		/// 
		public cloze_.Polygon4dbl _toCloze(int _countOfArcs_plural) {
			/// find the nearest point.
			/// or the furthest.
			///

			var left = this._hole.center.x;
			var right = this._bloc.boxed.width.dblen.ee - this._hole.center.x;
			var bottom = this._hole.center.y;
			var top = this._bloc.boxed.height.dblen.ee - this._hole.center.y;

			//find the nearest. for polygon that is not convex, nearest link from inner to outer can be sure not intersecting any lines.

			/// todo: rotate, and later rotate back.

			var circlePolygon = this._hole._sectAsPolygon_assumePositive(
				_countOfArcs_plural
			);

			return new cloze_.Polygon4dbl(
				new[] {
					circlePolygon.vertexes.First()
				}.Concat(
					circlePolygon.vertexes.Reverse()
				).Concat(
					new[] {
						new Point4dbl(
							this._bloc.boxed.width.dblen.ee
							
							,
							this._bloc.boxed.height.dblen.ee/2
						)
					}
				)
				.Concat(
					new[] {
						this._bloc.vertexes.ElementAt(2)
						,
						this._bloc.vertexes.ElementAt(3)
						,
						this._bloc.vertexes.ElementAt(0)
						,
						this._bloc.vertexes.ElementAt(1)
						,
						new Point4dbl(
							this._bloc.boxed.width.dblen.ee
							
							,
							this._bloc.boxed.height.dblen.ee/2
						)
					}
				)
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_countOfArcs_plural"></param>
		/// <returns>the points count might be different from indexes count.</returns>
		public (Point4dblI[], int[]) _toClozeInControls(int _countOfArcs_plural) {
			/// find the nearest point.
			/// or the furthest.
			///

			var left = this._hole.center.x;
			var right = this._bloc.boxed.width.dblen.ee - this._hole.center.x;
			var bottom = this._hole.center.y;
			var top = this._bloc.boxed.height.dblen.ee - this._hole.center.y;

			//find the furtherst

			/// todo: rotate, and later rotate back.

			var circlePolygon = this._hole._sectAsPolygon_assumePositive(
				_countOfArcs_plural
			);
			var circPointFirst = circlePolygon.ee.ee.vertexes.First()
				;
			var circPointsTorso = circlePolygon.ee.ee.vertexes.Skip(1).Reverse();

			var circlePolygonAsHole = nilnul.obj.seq.op_.unary_._PrependX.Prepend(circPointFirst, circPointsTorso);

			var controlPoints = circlePolygonAsHole.Concat(
				new[] {
						new Point4dbl(
							this._bloc.boxed.width.dblen.ee
							
							,
							this._bloc.boxed.height.dblen.ee/2
						)
				}
			).Concat(
					new[] {
						this._bloc.vertexes.ElementAt(2)
						,
						this._bloc.vertexes.ElementAt(3)
						,
						this._bloc.vertexes.ElementAt(0)
						,
						this._bloc.vertexes.ElementAt(1)
						
					}
			);
			var i = 0;

			return (
				controlPoints.ToArray()
				,
				Enumerable.Range(0,_countOfArcs_plural)
				.Concat(
					new int[]
					{
						0
					}
				)  //the circle ends here
				.Append(
					
					_countOfArcs_plural	//the midpoint of polygon edge
				)
				//.Append(
					
				//	_countOfArcs_plural+1	//the midpoint of polygon edge
				//)
				.Concat(
					new[] {
						i=_countOfArcs_plural+ 1
						,
						++i
						,
						++i
						,
						++i
						,
						_countOfArcs_plural
							// then the point[0]
					}
				).ToArray()
			);
		}


		//public (Point4dblI[], int[]) _toControlsHoled(int _countOfArcs_plural) {
		//	/// can the polygon be holed?
		//	/// as the algorithm for whether point is in hole can allow this.
	
		//}

		public int arcs = 16;
		public XElement draw()
		{
			var controls = _toClozeInControls(arcs);
			var ctrs1 = controls.Item1;

			return zone_.gon.draw_._ByGradsX.El_assumeStarted(
				controls.Item2.Select(i=> ctrs1[i])
			);

		}
	}
}