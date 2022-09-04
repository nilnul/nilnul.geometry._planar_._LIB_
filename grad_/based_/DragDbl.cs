using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


namespace nilnul.geometry.planar.grad_
{
	static public class _DragDblX
	{
		static public PointDbl End(PointDbl start, nilnul.geometry.planar.Vector4dblI vector) {
			return new PointDbl(
				start.x + vector.point.x
				,
				start.y + vector.point.y
			);
		}
	}
	/// <summary>
	/// a point with a vector
	/// </summary>
	/// <remarks>
	/// alias:
	///		based vector
	///		
	/// </remarks>
	public class DragDbl
		:Step4dblI
	{
		private nilnul.geometry.planar.Point4dblI _basis;

		public nilnul.geometry.planar.Point4dblI basis
		{
			get { return _basis; }
			set { _basis = value; }
		}

		private nilnul.geometry.planar.Vector4dblI _vector;

		public nilnul.geometry.planar.Vector4dblI vect
		{
			get { return _vector; }
			set { _vector = value; }
		}

		public CoD points =>new CoD(
			_basis
			,
			_DragDblX.End(_basis, _vector)
		);

		public DragDbl(PointDbl origin, Vector4dblI vector)
		{
			_basis = origin;
			_vector = vector;
		}

		public nilnul.geometry.planar._bloc.SpreadDbl size {
			get {
				return nilnul.geometry.planar._bloc.SpreadDbl.Of(vect);
			}
		}

	

		

		public PointDbl end => this._basis+this._vector;

		static public DragDbl CreateFroPointDuo(point.CoD pointDuo) {

			return new DragDbl(
				pointDuo.component
				,
				new planar.VectorDbl(pointDuo.component1 - pointDuo.component)
			);

		}

		static public DragDbl _GetBoundingBox(IEnumerable<nilnul.geometry.planar.PointDbl> _points_started)
		{

			var minX = nilnul.num.real.str_.started._MinX.Min(_points_started.Select(p => p.x));

			var minY = nilnul.num.real.str_.started._MinX.Min(_points_started.Select(p => p.y));

			var maxX = nilnul.num.real.str_.started._MaxX.Max(_points_started.Select(p => p.x));

			var maxY = nilnul.num.real.str_.started._MaxX.Max(_points_started.Select(p => p.y));

			return CreateFroPointDuo(
				new PointDbl(
					minX, minY
				)
				,
				new PointDbl(maxX,maxY)
				
			);

		}

		private static DragDbl CreateFroPointDuo(PointDbl point1, PointDbl point2)
		{
			return CreateFroPointDuo(new point.CoD(point1,point2));
			//throw new NotImplementedException();
		}
	}
}
