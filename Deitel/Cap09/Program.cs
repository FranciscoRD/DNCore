using System;
using Cap09.QueryingArray;//    9.2
using Cap09.QueryingEmployee;// 9.3
using Cap09.Colecciones;//      9.4

namespace Cap09
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 9.5 Querying the Generic List Collection
            LINQWithListCollection.Principal();
            #endregion

            #region 9.4 Introduction to Collections
            // ListCollection.Principal();
            #endregion
            
            #region 9.3 Querying an Array of Employees
            //LINQWithArrayObjects.Principal();
            #endregion
            
            #region 9.2 Querying an Array in LINQ
            // LINQWithSimpleTypeArray.Principal();
            #endregion
        }
    }
}
