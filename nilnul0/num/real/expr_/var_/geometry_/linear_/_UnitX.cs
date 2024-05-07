using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.var_.geometry_.linear_
{
	static public class _UnitX
	{
		

		static public unitan.Quantitied ToDeviationByStd<TUnit>(
			TUnit src
		)
			where TUnit : geometry.linear_._measured.UnitI
		{
			return new unitan.Quantitied(
				src.magnitude
				,
				geometry.linear_._measured.Unit.Singleton
			);
		}


		/// <summary>
		/// eg:
		///		  mm^2 
		///		=  (0.1 cm)^2 
		///		=.01 cm^2
		/// </summary>
		/// <returns></returns>
		static public unitan.Quantitied ToDeviation<TUnitSrc,TUnitTgt>(
			TUnitSrc src
			,
			TUnitTgt tgt
		//var_.geometry_.linear_.UnitI unit
		)
			where TUnitSrc : geometry.linear_._measured.UnitI
			where TUnitTgt: geometry.linear_._measured.UnitI

		{
			if (object.ReferenceEquals( src , tgt) )
			{
				return new unitan.Quantitied(tgt);
			}

			/// eg: this is mm, and par is cm
			///		we have:
			///			mm= 1/1000 m
			///			cm =1/100 m
			///			then, divide the two equation
			///			mm /cm = 1/1000 / (1/100)
			///		then
			///				mm= (1/1000 / (1/100)) cm
			///					= 0.1cm
			///
			/// note here even if two unit with same magnitude are named differently, we will still get the correct result as long as the real dividion works out;
			return new unitan.Quantitied(
				src.magnitude.real.en.ToReal()
				/

				tgt.magnitude
				,
				tgt
			);
		}
	}
}