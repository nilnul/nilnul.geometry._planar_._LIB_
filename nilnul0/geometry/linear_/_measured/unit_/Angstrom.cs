using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit_
{
	/// <summary>
	/// 10^-7 m
	/// </summary>
	public class Angstrom
		: UnitA
	{
		/// <summary>
		/// </summary>
		/// <remarks>
		/// some would use "埃", not 埃米, but that is still confusing.
		/// </remarks>
		public const string InCn = "盎米";
		public Angstrom() : base(
			nilnul.num.Quotient1.CreateUnit(1000_000_0)
		)
		{
		}



		static public Angstrom Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Angstrom>.Instance;
			}
		}


	}
}
