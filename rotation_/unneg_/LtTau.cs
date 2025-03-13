using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation_.nonneg_
{
	/// <summary>
	/// also know as Direction
	/// </summary>
	public class LtTau
		: nilnul.num.real_.nonneg_.LtTau
		,RotationI1
	{
		public LtTau(num.real_.nonneg_.LtTau val) : base(val)
		{
		}

		public _rotation.UnitI unit => _rotation.Unit.Singleton;

		public Real quantity => new Real( this);

		static public Rotation1 operator -(LtTau a, LtTau b) {
			return a - b;
		}
	}
}
