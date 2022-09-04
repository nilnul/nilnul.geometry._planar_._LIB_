//using nilnul.geometry.planar.curve_.cloze_.polygon_.points;
using nilnul.geometry.planar.lead.vsArrow;
using nilnul.geometry.planar.lead.vsArrow._layout;
using nilnul.geometry.planar.sub_.directed_.connected_.gon;
//using nilnul.geometry.planar.point.str_.started;
//using nilnul.geometry.planar.trail_.cloze_.polygon_.points;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.zone_.gon_.convex.vsLead
{
	//[Obsolete("need further investigation and testing")]
	static public class _SectDblX
	{
		/// <summary>
		///  cut off and obtain the half in the leeway
		/// </summary>
		/// <param name="_points_compressed"></param>
		/// <param name="sectingLead">lead</param>
		/// <returns></returns>
		/// <remarks>
		///	implementation:
		///		imaging we rotate the arrow of polygon,
		///			when meet with the lead/line, we store later points in new polygon
		///				then we decide on which side of the line our halved polygon is
		/// </remarks>
		/// 
		static public IEnumerable<Point4dbl> Eval(point.str_.SeqDblI _points_compressed, planar.IRayDbl sectingLead)
		{
			///loop thru each arrow
			///		if met with lead, deal with it in particular

			var arrows = _points_compressed._Arrows_assumeCompressed();


			var polygonHalf0_latter = new List<Point4dbl>(); // when looping thru grads, the grads looped before "lead" intersect any grad (in the middle or at the end)

			var polygonHalf1 = new List<Point4dbl>();    //when looping thru grads, after grads that are looped before any crossing, the grads crossed by "lead"

			var polygonHalf0_former = new List<Point4dbl>(); // previous to sectedPart0 (if sectedPart0 is at the leeway, then this part is also at the leeway)

			var intersectionPointsCount = 0; // Note: ray can intersect polygon at two points at two arrows. is the interesection is first or later?


			var polygonHalves = new[] { polygonHalf0_latter, polygonHalf1, polygonHalf0_former };

			var currentSectedIndex = 0;


			///  the lead will be spliced and becomes part of the halved polygon. this indicates whether the lead is in the same direction of the half polygon
			bool? part0PositiveOfSlicedLead = null;

			for (int i = 0; i < arrows.Count(); i++) //loop thru all points of  grads. Note this method is around the points, not the ray; we traverse points, when met with ray, deal with it, and then continue to traverse
			{
				var currentArrow = arrows.ElementAt(i);
				var intersectionResult = _LayoutDblX.Eval(sectingLead, currentArrow);

				if (
					intersectionResult is lead.vsArrow._layout.ret_.fork_.MiddleOrEndI intersectionResultAsIntersection //intersection point is valid (in arrow)
				)
				{
					if ((intersectionResult is lead.vsArrow._layout.ret_.fork_.FroLeewayI))  
					{
						if (intersectionPointsCount == 0)       //this is the first intersection
						{
							part0PositiveOfSlicedLead = false;       /// clockwise or counter clockwise
						}
					}
					else//from restrict
					{
						if (intersectionPointsCount == 0)       //this is the first intersection
						{
							part0PositiveOfSlicedLead = true;/// clockwise or counter clockwise
						}
					}

					intersectionPointsCount++;

					var intersectedPoint = intersectionResultAsIntersection.point;

					polygonHalves[currentSectedIndex].Add(intersectedPoint);    /// the first  point-list: latter points of one-half of the polygon;  or 

					currentSectedIndex++; //when there is cross, this increases
					//currentSectedIndex %= 3;    //this line is redundant as the above line will be executed at most twice.

					/// grads that crosses
					polygonHalves[currentSectedIndex].Add(intersectedPoint);        //the second point-list: other half of the polygon


					///if (intersectedPoint != currentArrow.end) // there is double.EPSILON problem
					if (!(intersectionResult is lead.vsArrow._layout.ret_.fork_.AtStopI) )
					{
					
						polygonHalves[currentSectedIndex].Add(new Point4dbl( currentArrow.end) );
					}
				}
				else if (intersectionResult is lead.vsArrow._layout.ret_.align_.Incident resultAsIncident)
				{

					///note: in previous arrow, the arrowEnd is already dealt with as intersection
					///		and currentHalfIndex is alread increased	
					if (resultAsIncident.sameDirection)
					{
						//part0PositiveOfSlicedLead = true;		/// not necessary as this has been done in previous interestion.

						//currentSectedIndex++;
						//polygonHalves[currentSectedIndex].Add(currentArrow.begin);  //supposing we let the ray cross the polygon in an infinitely close line parallel to the arrow
						polygonHalves[currentSectedIndex].Add(new Point4dbl( currentArrow.end ));
					}
					else
					{
						//part0PositiveOfSlicedLead = false;
						//currentSectedIndex++;
						//polygonHalves[currentSectedIndex].Add(currentArrow.begin);
						polygonHalves[currentSectedIndex].Add(new Point4dbl(currentArrow.end ));  //supposing we let the ray cross the polygon in an infinitely close line parallel to the arrow
					}
					currentSectedIndex++;
					polygonHalves[currentSectedIndex].Add(new Point4dbl(currentArrow.end));
					//intersectionPointsCount++;		//not useful

				}
				else  // nocross:  intersected at the begin, or the intersection point is outside the arrow, or align but submerge
					  //if (intersectionResult is _bisect._IntersectDblX.Result.AlignI intersectionResultAsAlign)
				{
					polygonHalves[currentSectedIndex].Add(new Point4dbl(currentArrow.end));
				}  //loop thru of every arrow  now ends
			}

			if (polygonHalf1.Count()==0)
			{
				if (planar.lead.vsPoint._LayoutX.LeewayFalse(sectingLead, _points_compressed.First() ) ==false)
				{
					return polygonHalf0_latter;
				}
				return new Point4dbl[0];
			}

			if (part0PositiveOfSlicedLead == true)
			{
				return (polygonHalf0_latter.Concat(polygonHalf0_former));
			}
			return (polygonHalf1);
		}
	}
}

