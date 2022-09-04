using nilnul.geometry.planar._grad_;
using nilnul.geometry.planar.point;
using nilnul.geometry.planar.point_;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


namespace nilnul.geometry.planar.grad_
{

	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	public class Skid4dbl_byBasedVect
		: Grad4dblI
	{
		private nilnul.geometry.planar.Point4dblI _basis;

		public nilnul.geometry.planar.Point4dblI basis
		{
			get { return _basis; }
			set { _basis = value; }
		}

	


		private nilnul.geometry.planar.vect_.NonnilDblI _vector;

		public nilnul.geometry.planar.vect_.NonnilDblI vector
		{
			get { return _vector; }
			set { _vector = value; }
		}

		

		public Skid4dbl_byBasedVect(Point4dbl origin, vect_.NonnilDbl vector)
		{
			_basis = origin;
			_vector = vector;
		}

		public Skid4dbl_byBasedVect(Point4dblI origin, vect_.NonnilDblI vector)
		{
			_basis = origin;
			_vector = vector;
		}

		
		public Skid4dbl_byBasedVect(Point4dblI basis, Vector4dblI vector1)
			:this(
				basis,

				new vect_.NonnilDbl(

				vector1
				)
			)
		{
		}

		public Skid4dbl_byBasedVect(Point4dbl basis, Vector4dblI vector1)
			:this(
				basis,

				new vect_.NonnilDbl(

				vector1
				)
			)
		{
		}

		public Skid4dbl_byBasedVect(Grad4dbl based4dbl)
			:this(based4dbl.basis,based4dbl.vect)
		{
		}

		//public Nonnil4dbl_byBasedVect(grad_.nonnil_.ByPoints nonnilDbl)
		//	:
		//	this(
		//	grad_.Grad4dbl.Of(nonnilDbl)
		//)
		//{
		//}


		public nilnul.geometry.planar.tope_._bloc.SpreadDbl size
		{
			get
			{
				return nilnul.geometry.planar.tope_._bloc.SpreadDbl.Of(vector);
			}
		}

		public Vector4dblI vect =>this._vector;
	}
}
