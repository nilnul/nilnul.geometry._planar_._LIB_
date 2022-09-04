using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.trigon.vsPoint_.inner_
{
	/// <summary>
	/// In a triangle ABC with sides a, b, and c, where the vertices are in counterclockwise order, there is exactly one point P such that the line segments AP, BP, and CP form the same angle, ω, with the respective sides c, a, and b
	/// Point P is called the first Brocard point of the triangle ABC, and the angle ω is called the Brocard angle of the triangle. This angle has the property that
	///		cot ω  =cot alpha +cot beta +cot gamma ,
	///		where alpha ,beta ,gamma are the vertex angles
	///
	///There is also a second Brocard point, Q, in triangle ABC.
	///  the difference between the first and the second depends on the order in which the angles of triangle ABC are taken. So for example, the first Brocard point of triangle ABC is the same as the second Brocard point of triangle ACB.
	/// Remarkably, this second Brocard point has the same Brocard angle as the first Brocard point. 
	/// </summary>
	/// <remarks>
	/// They are named after Henri Brocard (1845–1922), a French mathematician.
	///
	/// </remarks>
	interface IBrocard
	{
	}
}
