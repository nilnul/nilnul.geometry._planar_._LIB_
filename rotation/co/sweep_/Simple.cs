using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation.co.sweep_
{
	/// <summary>
	/// no incident/intersection. but can be trivia:(the change is nil.)
	/// </summary>
	public class Simple
	{

		rotation_.nonneg_.LtTauOfDbl _start;
		public rotation_.nonneg_.LtTauOfDbl start
		{
			get { return _start; }
			set { _start = value; }
		}


		rotation_.gtNegTau_.LtTau4Dbl _change;

		public rotation_.gtNegTau_.LtTau4Dbl change
		{
			get { return _change; }
			set { _change = value; }
		}
		public Simple(
			rotation_.nonneg_.LtTauOfDbl _start
			,
			rotation_.gtNegTau_.LtTau4Dbl sweep0

		)
		{
			this._start = _start;
			this._change = sweep0;

		}

		public Simple(
			num.real_.nonneg_.LtTauOfDouble _start0
			,
			num.real_.gtNegTau_.LtTau4Dbl sweep0

		)
			:this(
				 new rotation_.nonneg_.LtTauOfDbl(_start0)
				 ,
				 new rotation_.gtNegTau_.LtTau4Dbl(sweep0)
				)
		{
			

		}

		public Simple(double start1, double sweep1)
			:this(
				 rotation_.nonneg_.LtTauOfDbl.Create_byCannonize(start1)
				
				 ,
				  new rotation_.gtNegTau_.LtTau4Dbl(sweep1)
			)
		{
		}
	}
}
