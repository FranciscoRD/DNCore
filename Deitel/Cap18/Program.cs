using System;
using Cap18.Sobrecarga;     //18.2
using Cap18.Genericos;      //18.3 - 18.4
using Cap18.ClaseGenerica;  //18.6

namespace Cap18
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 18.6 Generic Classes
            StackTestV2.Principal();
            // StackTest.Principal();
            #endregion

            #region 18.4 Type Contsraints
            // MaximunTest.Principal();
            #endregion

            #region 18.3 Generic-Method Implementation
            // GenericMethod.Principal();
            #endregion

            #region 18.2 Motivation for Generic Methods
            // OverloadedMethods.Principal();
            #endregion
        }
    }
}
