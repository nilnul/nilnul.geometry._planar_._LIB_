using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NonNeg = nilnul.num.real.double_.NonNegativeX2.Asserted;

namespace nilnul.geometry.planar.cycle_.trigon.edges
{
	public  class LengthsDouble
	{


		private nilnul.num.real.double_.NonNegativeX2.Asserted _a, _b, _c;

		public NonNeg a
		{
			get
			{
				return _a;

			}
		}
		public NonNeg b
		{
			get
			{
				return _b;

			}
		}
		public NonNeg c
		{
			get
			{
				return _c;

			}
		}

		public LengthsDouble(NonNeg a,NonNeg b,NonNeg c)
		{
			if (CheckTwoCoverOne(a,b,c) && CheckTwoCoverOne(b,c,a) && CheckTwoCoverOne(c,a,b) )
			{
				this._a = a;
				this._b = b;
				this._c = c;

			}
			else
			{
				throw new Exception("Two of the lines altogether are shorter than or equal to the third line.");

			}


		}

		public LengthsDouble(double a,double b,double c)
			:this(new NonNeg(a),new NonNeg(b),new NonNeg(c))
		{

		}

		

		static public bool CheckTwoCoverOne(NonNeg a,NonNeg b,NonNeg c) {

			return (a.val+b.val)>=(c.val);
		
		}

		public double perimeter() {
			return a.val + b.val + c.val;
		}

		public double semiPerimetr() {
			return .5 * perimeter();
		}
	
	}
}
