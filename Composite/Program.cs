using System;
using System.Collections.Generic;

namespace Composite
{
    /*
     * A way to understand composite pattern is by imagining a tree structure. In this example we implement through the interface Iemployee a method called "Designation"
     * which we deliver to other classes through inheritance. This inheritance works in cascade in the sense that, for example, I can use the CEO to reach other classes, but I 
     * can't start from the bottom of the class and reach the top parts. 
     * 
     *           CEO
     *            |
     *            |
     *          /   \
     *         /     \
     *       HM_1   HM_2
     *        |
     *        |
     *   Area Manager
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployee AreaManager = new AreaManager();
            IEmployee Hm_1 = new HeadManager_1();
            IEmployee CEO = new CEO();

            List<IEmployee> employees = new List<IEmployee>();

            employees.Add(AreaManager);
            employees.Add(Hm_1);
            employees.Add(CEO);

            foreach (IEmployee employee in employees)
            {
                employee.Designation();
            }
            Console.ReadKey();
        }
    }
    //NOTE: Pay special attention to how the other classes and it's methods are built
}
