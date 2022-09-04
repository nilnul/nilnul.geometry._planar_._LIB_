using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.Real;
using Rx = nilnul.num.RealIX;
using RI = nilnul.num.RealI;

using nilnul.num;

namespace nilnul.geometry.original
{
	
	public class Vec :
		VecI
		
	{
		private original.IPoint _point;

		public original.IPoint point
		{
			get { return _point; }
			set { _point = value; }
		}


		public Vec(original.IPoint point)
		{
			this._point = point;
		}



		
	}
}
