using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation.be_
{



	/// <summary>
	/// </summary>
	public class Acute : rotation.BeOfDblI

	{
		public bool be(double obj)
		{
			return obj > 0 && obj < 90;
			//throw new NotImplementedException();
		}
	}
}