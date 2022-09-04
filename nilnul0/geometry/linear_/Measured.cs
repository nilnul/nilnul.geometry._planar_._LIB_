using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_
{
	/// a linear geometry with different measure is a rebase, or even affine trans, of the original linear geometry.
	/// As a result, we can map from original space to the new one.
	///
	/// <see cref="nameof(nilnul.time)"/>: follow the structure there to define measure.
	///		<see cref="nameof(IMeasured)"/> --> <see cref="nameof(nilnul.ITime)"/>
	///		<see cref="nameof(nilnul.time.IDuration)"/>, which inherits <see cref="nameof(nilnul.time.span.IMeasure)"/>  : <see cref="nameof(nilnul.geometry.linear_.measured.span.IDistance)"/>
	/// <summary>
	/// a meansured space. The axis is measured, in other words, with unit
	/// The neg ray is measured in opposite direction. to emphasize that they use the same unit, or same euclidean measure (the dimension of measure), 
	///
	/// We denote this opposite measure as an extension of measure, and extend that at this project: we call it the deviation.
	/// </summary>
	public interface IMeasured
	{
	}
}
