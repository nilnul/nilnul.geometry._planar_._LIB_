using System;

namespace nilnul.geometry.planar.zone_.trigon
{
	public class BeDouble :
		nilnul.obj.Be1<planar.zone_.Trigon4dblI>
		,
		BeDoubleI
	{
		public BeDouble(Func<Trigon4dblI, bool> func) : base(func)
		{
		}

	}
}
