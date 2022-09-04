using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Quotient = nilnul.num.real_.Quotient;
using R = nilnul.num.Real;

namespace nilnul.geometry.planar._area.unit
{
	public class SqMeter : UnitI
	{
		public Quotient asSqMeters
		{
			get
			{
				return Quotient.CreateOne();
				throw new NotImplementedException();
			}
		}

		public num.real_.PositiveI magnitude => new num.real_.Positive(asSqMeters);

		
	}
}
