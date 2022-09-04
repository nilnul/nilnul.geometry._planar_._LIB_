using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ieee.op_._interpolate
{
	/// <summary>
	/// With a started str of points that is ordered ascendently, output a number interpolatedly:
	///		if input lt than all, the image of the lowest point should be given
	///		if input gt than all, the image of the largest point should be given.
	/// </summary>
	public class Seeds

	{
		private nilnul.num.ieee.rel.be_.Seeded.En _seededRel;

		public nilnul.num.ieee.rel.be_.Seeded.En seededRel
		{
			get { return _seededRel; }
			set { _seededRel = value; }
		}


		public Seeds(nilnul.num.ieee.rel.be_.Seeded.En seededRel)
		{
			_seededRel = seededRel;
		}

		public double min {
			get {
				return _seededRel.avowed.Select(x => x.Item1).Min();

			}
		}

		public double max {
			get {
				return _seededRel.avowed.Select(x => x.Item1).Max();
			}
		}

		public double _valAt(double item1) {

			return _seededRel.avowed.Single(x=>x.Item1==item1).Item2;
			
		}






		
	}
}
