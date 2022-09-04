using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid.vsPoint._layout
{
	public enum Category
	{
		Behind = nilnul.geometry.linear.vect_.positive.vsPoint._layout.Category.Behind
			,
		Start= nilnul.geometry.linear.vect_.positive.vsPoint._layout.Category.Start
			,

		Between= nilnul.geometry.linear.vect_.positive.vsPoint._layout.Category.Between
			,
		Stop= nilnul.geometry.linear.vect_.positive.vsPoint._layout.Category.Stop
			,
		Forward= nilnul.geometry.linear.vect_.positive.vsPoint._layout.Category.Forward
			,
		/// <summary>
		/// <see cref="lead.vsPoint._layout.Sign.Restrict"/>
		/// </summary>
		External
			,
		Incident
		,
		/// <summary>
		/// <see cref="lead.vsPoint._layout.Sign.Leeway"/>
		/// </summary>
		Interior

	}
}
