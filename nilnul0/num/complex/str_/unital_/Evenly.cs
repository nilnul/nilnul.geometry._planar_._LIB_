using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.complex.str_.unital_
{
	/// <summary>
	/// evenly distributed
	/// </summary>
	static public class _EvenlyDistributedX
	{
		static public IEnumerable<num.complex_.polar_.Unital4dbl> _AssumePositive(int _positive)
		{
			var oneAngle = Math.PI * 2 / _positive;

			for (int row00 = 0; row00 < _positive; row00++)
			{

				var initial = 0d;
				yield return new num.complex_.polar_.Unital4dbl(
					initial
				);


				initial += oneAngle;

			}

		}

	}
}
