using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.grad_.nontrivia.map_
{
	/// <summary>
	/// map a grad to another grad by streching
	/// </summary>
	/// <remarks>
	/// alias:
	///		affine transform in 1d.
	/// </remarks>
	/// <see cref="linear.morph_.Affine4dbl"/>
	public class TgtGrad4Dbl
		:
	nilnul.num.real.op_.Unary4dblI
	{
		private grad_.Nontrivia4dbl	 _src;

		public grad_.Nontrivia4dbl src
		{
			get { return _src; }
			set { _src = value; }
		}

		private GradDbl _tgt;

		public GradDbl tgt
		{
			get { return _tgt; }
			set { _tgt = value; }
		}

		 double _srcLengthCached;
		double _tgtLengthCached;
		double _scaleCached;
		double _shiftCached;

		public TgtGrad4Dbl(
grad_.Nontrivia4dbl	 src0
			,
GradDbl tgt0
			)
		{
			this._src = src0;
			this._tgt = tgt0;
			_srcLengthCached = _src.distance;
			_tgtLengthCached = _tgt.distance;
			_scaleCached = _tgtLengthCached / _srcLengthCached;
			_shiftCached = _tgt.component.coord - this._src.Item1.coord *_scaleCached;





		}

		public TgtGrad4Dbl(
			double srcStart, double srcEnd
						,
			double tgtStart, double tgtEnd
		):this(
				new Nontrivia4dbl(srcStart,srcEnd)
				,
				new GradDbl(tgtStart,tgtEnd)
		)
		{
		}

		static public TgtGrad4Dbl OfShafts(
			double anchor, double length
			,
			double anchor1, double length1
		) {
			return new TgtGrad4Dbl(
				anchor, anchor +length
				,
				anchor1,anchor1 +length1
			);
		}

		public double scale {
			get {
				return  _scaleCached;
			}
		}

	
		/// <summary>
		/// <see cref="trans(double)"/>
		/// </summary>
		public double shift {
			get {
				return  _shiftCached;
			}
		}

		public double op(double _inSrc)
		{
			return _inSrc * _scaleCached + _shiftCached;
			//return ( _inSrc - this._src.Item1.coord) / this._src.distance * _tgtLengthCached + _tgt.component.coord;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_inSrc">can be anywhere. not necessary in the src</param>
		/// <returns></returns>
		///
		[Obsolete()]
		public double trans(
			double _inSrc
		) {
			return op(_inSrc);
		}


	}
}
