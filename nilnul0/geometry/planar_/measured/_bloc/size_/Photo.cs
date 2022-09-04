using nilnul.geometry._linear;
//using nilnul.geometry.planar.bloc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar_.measured._bloc.size_
{
	static public class Photo_
	{

		public class TwoInch
			:
			nilnul.geometry.planar_.measured._bloc.Size1
		{

			public TwoInch() : base(
				new nilnul.geometry.linear_.measured.span.Distance(
					25
					,
					nilnul.geometry.linear_._measured.unit_.Mm1.Singleton
				)
				,
				new nilnul.geometry.linear_.measured.span.Distance(
					35
					,
					nilnul.geometry.linear_._measured.unit_.Mm1.Singleton
				)
			)
			{
			}
		}

		public class OneInch
			:
			Size1
		{
			public OneInch():base(
				new nilnul.geometry.linear_.measured.span.Distance(
					35
					,
					nilnul.geometry.linear_._measured.unit_.Mm1.Singleton
				)
				,
				new nilnul.geometry.linear_.measured.span.Distance(
					53
					,
					nilnul.geometry.linear_._measured.unit_.Mm1.Singleton
				)
			)
			{
			}
		}


	}
}
