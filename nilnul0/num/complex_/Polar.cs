//using nilnul.num.complex_.polar_.unital_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.complex_
{

	public class Polar:nilnul.num.ComplexI
	{
		private nilnul.num.RealI _radius;

		public R radius
		{
			get { return _radius; }
			set { _radius = value; }
		}
		private R _azimuth;

		public R azimuth
		{
			get { return _azimuth; }
			set { _azimuth = value; }
		}

		public R x => radius.ToReal()*nilnul.num.real.op_.unary_.Cos.Singleton.op(_azimuth);

		public R y =>radius.ToReal()* nilnul.num.real.op_.unary_.Sin.Singleton.op(_azimuth) ;

		public Polar(  R radius, R azimuth)
		{
			this._azimuth = azimuth;
			this._radius = radius;
		}

		public Polar(int v, R azimuth):
			this(
				new nilnul.num.real_.Quotient(v)
				,
				azimuth
			)
		{
		}

		/// <summary>
		/// make radius nonneg by rotating half round when necessary.
		/// </summary>
		public void normalize() {
			if (radius.ToReal()==0)
			{
				this._azimuth = (Real)0;
			}
			if (radius.ToReal()<0)
			{
				this._radius = -radius.ToReal();
				this._azimuth += nilnul.num.real_.TauX.Half;
			}
		}


		public polar_.Std toStd() {
			return new polar_.Std(this);
		}

		/// <summary>
		/// euler form: r*e^a
		/// then
		///		1/4 * e^-a
		/// </summary>
		/// <returns></returns>
		public Polar inverse() {
			return new Polar(
				 1/ this._radius.ToReal(), -_azimuth.ToReal()
			);
		}
		public override string ToString()
		{
			return $"{_radius}*{num.complex_.polar_._UnitalX.PhraseOfAzimuthWithNoParen(this._azimuth)}";
		}

		
		public string phraseByFloating() {
			return $"{_radius}{num.complex_.polar_._UnitalX.PhraseByFloatingOfAzimuthWithNoParen(this._azimuth)}";
		}


		private static Polar OfCartesian(R real, R imaginary)
		{
			return new Polar(
				nilnul.num.real.str.to_.scalar_.Norm.Singleton.to(
					new[] {
					real, imaginary
					}
				)
				,
				nilnul.num.real.op_.binary_.trigonometic_._AgradX.ArgGradient
				(
					 real
					 ,
					 imaginary
				)
			);
			
		}

	}
}
