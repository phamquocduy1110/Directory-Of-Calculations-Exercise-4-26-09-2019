using System;

namespace UnitTest_Examples
{
    public class Triangle
    {
        public string CheckTriangle(string[] arr_trianglesides)
        {
            int sidea, sideb, sidec;
            string sTriangleMessage = "";
            string isATriangle;

            try
            {
                sidea = int.Parse(arr_trianglesides[0]);
                sideb = int.Parse(arr_trianglesides[1]);
                sidec = int.Parse(arr_trianglesides[2]);

                if (sidea <= 0 || sideb <= 0 || sidec <= 0)
                    isATriangle = "WV";
                else if ((sidea < sideb + sidec) && (sideb < sidea + sidec) && (sidec < sidea + sideb))
                    isATriangle = "Yes";
                else
                    isATriangle = "No";

                if (isATriangle == "Yes")
                    if ((sidea == sideb) && (sideb == sidec))
                        sTriangleMessage = "It's an Equilateral Triangle";
                    else if ((sidea == sideb) || (sideb == sidec) || (sidea == sidec))
                        sTriangleMessage = "It's an Isosceles Triangle";
                    else
                        sTriangleMessage = "It's a Scalene Triangle";
                else if (isATriangle == "No")
                    sTriangleMessage = "It's not a Triangle";
                else
                    sTriangleMessage = "The length of triangle side must be an integer and greater than zero";
            }
            catch (Exception ex)
            {
                sTriangleMessage = "The length of triangle side must be an integer and greater than zero";
            }

            return sTriangleMessage;
        }
    }
}