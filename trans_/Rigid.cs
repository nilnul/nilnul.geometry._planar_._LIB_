using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trans_
{
	/// when the object is rigid, we can only change the axis.
	/// <summary>
	///	preserve distance between points. move the object freely in a space, without incur any destroyance onto it.
	/// include:
	///		translate
	///		flip (have to be done by extending in 3d space). scale by ratio of -1.
	///		roate
	///	not have
	///			scale
	///			shear
	/// </summary>
	/// <remarks>
	/// The rigid transformations include rotations, translations, reflections, or any sequence of these.
	/// 
	///	a sequnce of flip, in that:
	///		1) a flip along a line, the flip the shape along a line can translate that shape.
	///		2) a flip along a ray from one point. the flip along a line inside can rotate.
	///	this implies that you can thus
	///		flip a few times and then translate.  then you can achive rigid.
	/// </remarks>
	/// the entity is unchanged. but we have new coordiante system established in addition to the new one.
	/// <seealso cref="Stiff"/>
	public interface IRigid:affine_.IRigid
	{
	}
}
