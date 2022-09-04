using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation_.nonneg_
{
	/// <summary>
	/// also know as: orientation,  align
	/// </summary>
	public class LtPi
		: nilnul.num.real_.nonneg_.LtPi
		,RotationI1
	{
		public LtPi(num.real_.nonneg_.LtPi val) : base(val)
		{
		}

		public _rotation.UnitI unit => _rotation.Unit.Singleton;

		Real RotationI1.quantity => new Real( this);
	}
}
