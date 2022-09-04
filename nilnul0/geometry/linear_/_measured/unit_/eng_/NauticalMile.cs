using System;

namespace nilnul.geometry.linear_._measured.unit_.eng_
{

	/// <summary>
	/// 1,852 
	/// </summary>
	public class NauticalMileDbl : IUnit
	{
		public const double MetersPerNauticalMile = 1852;
		public double AsMeters
		{
			get
			{
				return MetersPerNauticalMile;
				
			}
		}
	}
}
