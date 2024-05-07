using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.Real;
using Rx = nilnul.num.RealIX;
using RI = nilnul.num.RealI;
using nilnul.num;
using nilnul.geometry.planar._rotation;
using nilnul.obj._measure_;

namespace nilnul.geometry.planar
{
	public interface RotationOfDoubleI<T>
		:
		linear_._measured.Mark4dblI<T>
		where T: _rotation.Unit4dblI
	{
		//double quantity { get; }
		//_rotation.UnitOfDoubleI unit { get; }
	}
	public interface RotationOfDoubleI
		:
		RotationOfDoubleI<_rotation.Unit4dblI>
	{
		//double quantity { get; }
		//_rotation.UnitOfDoubleI unit { get; }
	}


}
