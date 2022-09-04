using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.matrix_.square_;

using R = nilnul.num.RealI;


namespace nilnul.geometry.planar.trans_.rebase_.scale_
{
	public class StretchVertically
		:
		trans_.rebase_.IScaleOnly
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
		public Two_Two matrix
		{
			get
			{
				return new Two_Two(
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
