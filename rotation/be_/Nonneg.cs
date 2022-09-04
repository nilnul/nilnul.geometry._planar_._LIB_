using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation.be_
{

	//public enum AngleWise
	//{
	//	Clockwise,
	//	AntiClockwise	//this is the positive diretion
	//}

	/// <summary>
	/// if it's negative (assuming y-axis points to upper)
	/// </summary>
	public class Nonneg :

		rotation.BeI
	{

		public bool be(RotationI1 obj)
		{
			return obj.quantity.ToReal() >= 0;
			throw new NotImplementedException();
		}


		static public Nonneg Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nonneg>.Instance;
			}
		}


	}
}
