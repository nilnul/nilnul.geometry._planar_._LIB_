using nilnul.geometry.planar._grad_;
using nilnul.geometry.planar.point;
using nilnul.geometry.planar.point_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


namespace nilnul.geometry.planar
{

	/// <summary>
	/// based vector
	/// </summary>
	/// <remarks>
	/// </remarks>
	///
	[Obsolete(nameof(Grad4dbl_byPoints))]
	public class Grad4dbl
		: Grad4dblI
		,
		_grad_.End4dblInImplI
		
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



	

		public Grad4dbl(Point4dbl origin, Vector4dblI vector)
		{
			_basis = origin;
			_vector = vector;
		}

		public Grad4dbl(Point4dblI origin, Vector4dblI vector)
		{
			_basis = origin;
			_vector = vector;
		}

		public nilnul.geometry.planar.tope_._bloc.SpreadDbl size
		{
			get
			{
				return nilnul.geometry.planar.tope_._bloc.SpreadDbl.Of(vect);
			}
		}

		public CoD points =>new CoD(this._basis,end );

		public Point4dbl end => planar.vect.op_.binary_._AddX.Point( this._basis , this._vector);



	}
}
