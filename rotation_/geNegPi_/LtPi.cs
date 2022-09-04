using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation_.geNegPi_
{
	public class LtPi : planar.rotation.be.en_.BeDefaulted<planar.rotation.be_.geNegPi_.LtPi>
	{
		public LtPi(RotationI1 val) : base(val)
		{
		}
		public LtPi(nilnul.num.RealI x):this( new planar.Rotation1(x))
		{

		}
	}
}
