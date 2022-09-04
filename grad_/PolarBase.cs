using nilnul.geometry.planar._grad_;
using nilnul.geometry.planar.point;
using nilnul.geometry.planar.point_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


namespace nilnul.geometry.planar.grad_.based_
{

	/// <summary>
	/// </summary>
	/// <remarks>

	/// </remarks>
	public class PolarBase
		: Step4dblI
	{
		private nilnul.geometry.planar.point_.Polar4dbl _basisInPolar;

		public nilnul.geometry.planar.point_.Polar4dbl basisInPolar
		{
			get { return _basisInPolar; }
			set { _basisInPolar = value; }
		}

		public nilnul.geometry.planar.Point4dbl originAsOrthogonal
		{
			get { return _basisInPolar.toStraight(); }
			set { _basisInPolar = Polar4dbl.Of(value); }
		}


		private nilnul.geometry.planar.Vector4dblI _vector;

		public nilnul.geometry.planar.Vector4dblI vect
		{
			get { return _vector; }
			set { _vector = value; }
		}

		public CoD points
		{
			get
			{
				var o = originAsOrthogonal;
				return new CoD(
o
, 
_StepX.End(o, _vector)
);
			}
		}

		public PolarBase(Polar4dbl origin, Vector4dblI vector)
		{
			_basisInPolar = origin;
			_vector = vector;
		}

		public Point4dblI end => planar.VectorDbl.Add(  this._basisInPolar , this._vector);


		public nilnul.geometry.planar.tope_._bloc.SpreadDbl size
		{
			get
			{
				return nilnul.geometry.planar.tope_._bloc.SpreadDbl.Of(vect);
			}
		}


		public Point4dblI basis => this._basisInPolar;
	}
}
