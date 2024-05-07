using nilnul.geometry.linear_._measured.unit.calc.amount_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit.calc_.indic
{
	public class Prod4dbl
		: nilnul.obj.Box1<
			IEnumerable<Indic4dbl>
		>
		,
		calc.amount_._one_.Reduce4dblI
	{
		public Prod4dbl(IEnumerable<Indic4dbl> val) : base(val)
		{
		}
		public Prod4dbl():this( new Indic4dbl[0])
		{

		}

		public Reduced4dbl reduce()
		{
			if (boxed.Any())
			{
				var first = boxed.First();

				foreach (var item in boxed)
				{
					var changedUnit=calc.amount_.reduced_.CoefOne.ChangeUnit(item, first.radic);


				}

			}
			
			var r = new calc.amount_.Coef(1);

			foreach (var item in boxed)
			{
				r = r * item ;

			}

			return r;
		}
	}
}
