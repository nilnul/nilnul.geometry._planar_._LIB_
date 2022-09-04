using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation_
{
	public interface NonnegI
		:RotationI1
	{
		nilnul.num.real_.NonnegI radian { get; }
	}

	public class Nonneg :
		nilnul.obj.Box<nilnul.num.real_.NonnegI>
		,
		NonnegI
	{
		public Nonneg(num.real_.NonnegI val) : base(val)
		{
		}

		public num.real_.NonnegI radian => boxed;

		public _rotation.UnitI unit => _rotation.Unit.Singleton;

		Real RotationI1.quantity => new Real(radian);

		static public Nonneg Abs(planar.RotationI1 rotation) {
			return new Nonneg(
				nilnul.num.real_.Nonneg.Abs(
				rotation.quantity
				)
			);
		}
	}
}
