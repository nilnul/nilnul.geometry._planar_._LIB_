using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.lead.vsPoint._sig_.by_
{
	internal class IByTorque
	{
		/*
		 I wanted to provide with a solution inspired by physics.

Imagine a force applied along the line and you are measuring the torque of the force about the point. If the torque is positive (counterclockwise) then the point is to the "left" of the line, but if the torque is negative the point is the "right" of the line.

So if the force vector equals the span of the two points defining the line

fx = x_2 - x_1
fy = y_2 - y_1
you test for the side of a point (px,py) based on the sign of the following test

var torque = fx*(py-y_1)-fy*(px-x_1)
if  torque>0  then
     "point on left side"
else if torque <0 then
     "point on right side"  
else
     "point on line"
end if


answered Dec 18, 2018 at 15:00
John Alexiou

stackoverflow.com/questions/1560492/how-to-tell-whether-a-point-is-to-the-right-or-left-side-of-a-line/1560510#1560510


		 */
	}
}
