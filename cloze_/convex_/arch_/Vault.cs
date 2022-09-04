using nilnul.geometry.planar.zone_.rect_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.convex_.arch_
{
	/// <summary>
	/// the arc is semicircle
	/// </summary>
	public interface IVault:IArch
	{
	}

	public class VaultDbl
		:
		nilnul.obj.Box1<
			nilnul.geometry.planar.zone_.rect_.OfFlexDbl
		>
		,
		IVault
	{
		public VaultDbl(OfFlexDbl val) : base(val)
		{
		}



	}
}
