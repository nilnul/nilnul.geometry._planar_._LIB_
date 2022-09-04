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
	public class TgtGrad4Dbl
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

		public double scale {
			get {
				return  _tgtLengthCached / this._src.distance ;
			}
		}

		public double shift {
			get {
				return _tgt.component.coord ;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_inSrc">can be anywhere. not necessary in the src</param>
		/// <returns></returns>
		public double trans(
			double _inSrc
		) {

			return _inSrc / this._src.distance * _tgtLengthCached + _tgt.component.coord;
		}



	}
}
