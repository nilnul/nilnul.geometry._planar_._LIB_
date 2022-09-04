using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


namespace nilnul.geometry.planar.grad_
{
	/// <summary>
	/// based
	/// </summary>
	static public class _DragX
	{
		static public Point1 End(PointI1 start, nilnul.geometry.planar.IVector vector) {
			return new Point1(
				start.x + vector.point.x
				,
				start.y + vector.point.y
			);
		}

		static public Point4dbl End(Point4dblI basis, planar.Vect4dblI vect) {

			return planar.vect.op_.binary_._AddX.Point(basis, vect);

		}

		static public Point4dbl End(Point4dbl basis, planar.Vect4dblI vect) {

			return End( (Point4dblI) basis, vect);

		}

		static public Point4dbl End(Point4dblI basis, planar.Vector4dblI vect) {

			return planar.vect.op_.binary_._AddX.Point(basis, vect);

		}

		
	}


	/// <summary>
	/// a point with a vector. This draws a rect in four orientations
	/// </summary>
	public class Drag
		:GradI
	{
		private nilnul.geometry.planar.PointI1 _origin;

		public nilnul.geometry.planar.PointI1 origin
		{
			get { return _origin; }
			set { _origin = value; }
		}

		private nilnul.geometry.planar.IVector _vector;

		public nilnul.geometry.planar.IVector vector
		{
			get { return _vector; }
			set { _vector = value; }
		}

		public Co points =>new Co(
			_origin
			,
			_DragX.End(_origin, _vector)
		);

		public Drag(PointI1 origin, IVector vector)
		{
			_origin = origin;
			_vector = vector;
		}

	

		static public Drag CreateFroPointDuo(point.ICo pointDuo) {

			return new Drag(
				pointDuo.component
				,
				new planar.Vector1(pointDuo.component1 - pointDuo.component)
			);

		}

		static public Drag _GetBoundingBox(IEnumerable<nilnul.geometry.planar.Point1> _points_started)
		{

			var minX = nilnul.num.real.aggregate_.Min.Eval(_points_started.Select(p => p.x));

			var minY = nilnul.num.real.aggregate_.Min.Eval(_points_started.Select(p => p.y));

			var maxX = nilnul.num.real.aggregate_.Max.Eval(_points_started.Select(p => p.x));

			var maxY = nilnul.num.real.aggregate_.Max.Eval(_points_started.Select(p => p.y));

			return CreateFroPointDuo(
				new Point1(
					minX, minY
				)
				,
				new Point1(maxX,maxY)
				
			);

		}

	

		private static Drag CreateFroPointDuo(Point1 point1, Point1 point2)
		{
			return CreateFroPointDuo(new point.Co(point1,point2));
			//throw new NotImplementedException();
		}
	}
}
