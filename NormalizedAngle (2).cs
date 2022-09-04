using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.number;
namespace nilnul.geometry.plane
{
	/// <summary>
	/// [0,Tau)
	/// </summary>
	public partial class NormalizedAngle
	{

		private double _val;
		public double val
		{
			get { return _val; }
		
		}

		public void set(NonnegDouble d) {

			if (check(d))
			{
				this._val = d.val;

			}
			else
			{
				throw new ArgumentOutOfRangeException("Expected a value less than Tau.");
			}
			
		}

		public bool check(NonnegDouble val) {

			if (val.val>=Tau.IntoDoulbe)
			{
				return false;
				
			}
			return true;
 

		
		}
		

		public NormalizedAngle(NonnegDouble d )
		{
			set(d);

		}


		public NormalizedAngle(double d)
		{
			set(new NonnegDouble(d));
		}
					
					
	}
}
