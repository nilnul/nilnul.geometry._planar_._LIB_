using nilnul.geometry.planar._area.unit_;
using nilnul.geometry.planar._area.unit_.eng_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quotient = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;

namespace nilnul.geometry.planar._area.unit.op_
{
	static public class _UnaryX
	{
		static public readonly Quotient Acre2Hectare = Acre.Singleton._magInQuotient / Hectare.Singleton._magInQuotient;

		static public readonly Quotient HectarePerAcre =Acre2Hectare;

		static public readonly Quotient Acre2SqYards = Acre.AsRoods * Rood.AsPerchs * Perch.AsSqYards;


	}
}
