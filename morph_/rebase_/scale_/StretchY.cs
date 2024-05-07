using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.matrix_.square_;

using R = nilnul.num.RealI;


namespace nilnul.geometry.planar.morph_.matrixed_.scale_
{
	public class StretchVertically
		:
		morph_.matrixed_.IScaleOnly
		,
		scale_.INontrivia
	{
		private R _multiplier;

		public R multiplier
		{
			get { return _multiplier; }
			set { _multiplier = value; }
		}


		public StretchVertically(R multiplier)
		{
			_multiplier = multiplier;

		}
		public Secondary matrix
		{
			get
			{
				return new Secondary(
					(nilnul.num.real_.Quotient)1
					,
					( nilnul.num.real_.Quotient)0
					,
					(nilnul.num.real_.Quotient)0
					,

					_multiplier
					
				);
				//throw new NotImplementedException();
			}
		}
	}
}
