using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.matrix_.square_;

using R = nilnul.num.RealI;


namespace nilnul.geometry.planar.morph_.matrixed_.scale_
{
	public class StretchHorizontally :
		morph_.matrixed_.scale_.INontrivia
		,
		morph_.IScale

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
		public Secondary matrix
		{
			get
			{
				return new Secondary(
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
