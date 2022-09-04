using nilnul.geometry.planar.grad.be_.nonnil.vow;
using nilnul.geometry.planar.point;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.grad_.skid_
{
	/// <summary>
	/// defined by two points
	/// </summary>
	public class ByPoints4Dbl :
		nilnul.geometry.planar.point.co.be_.dif.vow.EeDbl
		//,
		//_grad_.VectDblI
		//,
		//_grad_._polar_.LengthDblI
		//,
		//grad_._nonnil_.Vect4dblI
		,
		grad_.Nonnil4dblI
		,
		grad_.Skid4dblI

		,
		grad_._skid_.End4dblInInterfaceI
		,

		ISkid

	{

		public Point4dblI begin
		{
			get { return ee.component; }
		}
		public Point4dblI end
		{
			get { return ee.component1; }
		}


		public ByPoints4Dbl(point.CoD duo) :
			base(duo)
		{

		}

		public ByPoints4Dbl(Point4dblI begin, Point4dblI end)
			: this(
				 new point.CoD(begin, end)
				 )
		{
		}
		public ByPoints4Dbl(double x,double y, double x1, double x2):this(
			new Point4dbl(x,y)
			,
			new Point4dbl(x1,x2)
		)
		{

		}

		public ByPoints4Dbl(Point4dblI basis, vect_.NonnilDblI vectNonnil1)
			:this(
				 basis,
				 grad_._StepX.End(
					basis,vectNonnil1
				 )
			)
		{
		}
		public ByPoints4Dbl(grad_.Nonnil4dblI duo) :
			this(duo.basis, duo.vectNonnil)
		{

		}
		static public ByPoints4Dbl Of(Point4dblI basis, vect_.NonnilDblI vectNonnil1)
			
		{
			return new ByPoints4Dbl(
				 basis,
				 grad_._StepX.End(
					basis, vectNonnil1
				 )
			);
		}

		static public ByPoints4Dbl Of(grad_.Nonnil4dblI duo) 
		{
			return Of(duo.basis, duo.vectNonnil);

		}



		public double integral()
		{

			//trapoid
			return (end.x - begin.x) * (end.y + begin.y) / 2;


		}

		public double direction
		{
			get
			{
				return planar.vect_.nonnil._DirectionX._Ge0LtTau_ofAssumeNonnil(
					grad_._StepX.Vect(
					this.ee.component
					,
					this.ee.component1
					)
				);
			}
		}
		public double azimuth
		{
			get
			{
				return planar.vect_.nonnil._AzimuthX._GtNegPiLePi__assumeNonnil(
					grad_._StepX.Vect(
					this.ee.component
					,
					this.ee.component1
					)
				);
			}
		}


		public VectorDbl vector => grad_._StepX.Vect(  this.begin,this.end);
		public Vector4dblI vect => vector;

		public NonnegOfDouble length => new NonnegOfDouble(
			this.vector.point.Deviation()
		);

		public vect_.NonnilDblI vectNonnil => new vect_.NonnilDbl(vector);

		public CoD points => new CoD(
			this.begin
			,
			this.end
		);

		public Point4dblI basis => this.boxed.component;

		public Ee4dbl gradee => new Ee4dbl(this);

		public Point4dblI finish => end;

		static public planar.grad_.skid_.ByPoints4Dbl operator +(
			ByPoints4Dbl nonnilDbl,
			nilnul.num.real_.NonnegOfDouble length
		)
		{

			return new ByPoints4Dbl(
				grad_.skid_.PolarBase.Add(nonnilDbl, length)
			)
			;

		}

	}
}
