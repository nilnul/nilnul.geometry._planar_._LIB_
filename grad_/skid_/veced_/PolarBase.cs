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


namespace nilnul.geometry.planar.grad_.skid_
{

	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	public class PolarBase
		: Grad4dblI
		,
		grad_.Nonnil4dblI
	{
		private nilnul.geometry.planar.point_.Polar4dbl _basis;

		public nilnul.geometry.planar.point_.Polar4dbl basisInPolar
		{
			get { return _basis; }
			set { _basis = value; }
		}

		public nilnul.geometry.planar.Point4dblI basis
		{
			get { return _basis; }
		}


		public nilnul.geometry.planar.Point4dbl originAsOrthogonal
		{
			get { return _basis.toStraight(); }
			set { _basis = Polar4dbl.Of(value); }
		}


		private nilnul.geometry.planar.vect_.NonnilDblI _vector;

		public nilnul.geometry.planar.vect_.NonnilDblI vector
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

		public PolarBase(Polar4dbl origin, vect_.NonnilDblI vector)
		{
			_basis = origin;
			_vector = vector;
		}
		public PolarBase(Polar4dbl origin, vect_.NonnilDbl vector)
		{
			_basis = origin;
			_vector = vector;
		}


		public PolarBase(Polar4dbl origin, vect_.nonnil_.Polar4dbl polar4dbl)
			:this(
				 origin,

				 polar4dbl.toOrthogonal() 
				)
		{

		}
		public PolarBase(Point4dblI basis, vect_.NonnilDblI vector1)
			:this(
				 Polar4dbl.Of(basis),vector1
			)
		{
		}

		public PolarBase(Point4dbl basis, vect_.NonnilDbl vector1)
			:this(
				 Polar4dbl.Of(basis),vector1
			)
		{
		}

		public PolarBase(Polar4dbl polar4dbl, Vector4dblI vector1)
			:this(polar4dbl, new vect_.NonnilDbl(vector1) )
		{
		}


		public PolarBase(
			Skid4dbl_byBasedVect based)
			:this(
				 based.basis,based.vector
			)
		{
		}
		public PolarBase(Nonnil4dblI based)
			:this(
				 based.basis,based.vect
			)
		{
		}

		//public PolarBase(ByPoints nonnilDbl):this(
		//	new grad_.Nonnil4dbl_byBasedVect(nonnilDbl)
		//)
		//{
		//}
		public PolarBase(Point4dblI basis, Vector4dblI vector1)
			:this(
				 Polar4dbl.Of(basis),vector1
			)
		{
		}

		public PolarBase(Point4dbl basis, Vector4dblI vector1)
			:this(
				 Polar4dbl.Of(basis),vector1
			)
		{
		}

		public PolarBase(Grad4dbl based4dbl)
			:this(based4dbl.basis,based4dbl.vect)
		{
		}


		public nilnul.geometry.planar.tope_._bloc.SpreadDbl size
		{
			get
			{
				return nilnul.geometry.planar.tope_._bloc.SpreadDbl.Of(vector);
			}
		}

		public vect_.NonnilDblI vectNonnil => this._vector;


		public Vector4dblI vect => this._vector;

		static public skid_.PolarBase Add(
			skid_.PolarBase nonnilDbl,
			nilnul.num.real_.NonnegOfDouble length
		)
		{

			return new PolarBase(
				nonnilDbl.basisInPolar
				
					
					,
				vect_.nonnil_.Polar4dbl.Add(
					nonnilDbl.vector , length
				
				)
			); 

		}
		public static skid_.PolarBase Add(
			ByPoints4Dbl nonnilDbl
			,
			NonnegOfDouble length
		)
		{
			return Add(
				new skid_.PolarBase(nonnilDbl)
				,
				length
			);
		}

		static public skid_.PolarBase operator +(
			skid_.PolarBase nonnilDbl,
			nilnul.num.real_.NonnegOfDouble length
		)
		{

			return Add(nonnilDbl,length); 

		}



	}
}
