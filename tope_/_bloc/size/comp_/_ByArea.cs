using nilnul.geometry.planar.tope_.bloc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tope_._bloc.size.comp_
{
	/// <summary>
	/// assumes each component is nonneg;
	/// </summary>
	public class _ByArea
		: IComparer<(double, double)>
		,
		IComparer<System.Drawing.Size>
	{
		public int Compare((double, double) x, (double, double) y)
		{
			return _AreaX._Area_01nonneg( x).CompareTo(bloc._AreaX._Area_01nonneg(y));

		}

		public int Compare(Size x, Size y)
		{
			return _AreaX.Area( x).CompareTo(bloc._AreaX.Area(y));

		}

		static public _ByArea Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<_ByArea>.Unison;
			}
		}

	}
}
