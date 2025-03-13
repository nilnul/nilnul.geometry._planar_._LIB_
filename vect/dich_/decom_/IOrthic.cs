using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.dich_.decompose_
{
	/// but a vect can be decomposed by any <see cref="planar.morph_.rebase_.shear_.IInvertible"/>, which is the linear combination of the vect.
	/// but here we will coalign|orthicize|decordinate it;
	///
	/// 
	/// <summary>
	/// given <see cref="planar.rotation_.align.co_.IPerpend"/>, we can decompose the vect into two vects along those two lines. 
	/// </summary>
	/// <remarks>
	/// useful in calculations. eg: in <see cref="nilnul.num.quarternion_.rotar"/> * versor, the versor is decomposed along the line of the rotar, and the line perpendicular to it.
	/// </remarks>
	/// 
	/// <see cref="morph_.rebase_.shear_.IInvertible"/>
	/// ,<see cref="morph_.rebase_.shear_.invertible._InvertX"/>
	/// alias:
	///		decompose, but it may mean <see cref="planar.morph_.rebase_.shear_.IInvertible"/> for a parallelogram.
	///		orthicize
	///		canonical combinate.
	///		perpend
	///		ortho
	///		desCarte
	///		
    public interface IOrthic
    {
    }

}
