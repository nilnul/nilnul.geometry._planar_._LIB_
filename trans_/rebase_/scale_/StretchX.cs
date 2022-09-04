using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.matrix_.square_;

using R = nilnul.num.RealI;


namespace nilnul.geometry.planar.trans_.rebase_.scale_
{
	public class StretchHorizontally :
		trans_.rebase_.scale_.INontrivia
		,
		trans_.IScale

	{
		private R _multiplier;

		public R multiplier
		{
			get { return _multiplier; }
			set { _multiplier = value; }
		}


		public StretchHorizontally(R multiplier)
		{
			_multiplier = multiplier;

		}
		public Two_Two matrix
		{
			get
			{
				return new Two_Two(
					_multiplier,
					( nilnul.num.real_.Quotient)0
					,
					(nilnul.num.real_.Quotient)0,
					(nilnul.num.real_.Quotient)1
				);
				//throw new NotImplementedException();
			}
		}
	}
}
