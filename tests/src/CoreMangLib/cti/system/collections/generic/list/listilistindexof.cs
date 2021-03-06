using System;
using System.Collections.Generic;
using System.Collections;
/// <summary>
///IndexOf(System.Object)
/// </summary>
public class ListIListIndexOf
{
    public static int Main()
    {
        ListIListIndexOf ListIListIndexOf = new ListIListIndexOf();
        TestLibrary.TestFramework.BeginTestCase("ListIListIndexOf");
        if (ListIListIndexOf.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        retVal = PosTest3() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Calling IndexOf method of IList,T is Value type.");
        try
        {
            List<int> myList = new List<int>();
            int count = 10;
            int[] expectValue = new int[10];
            IList myIList = ((IList)myList);
            object element = null;
            for (int i = 1; i <= count; i++)
            {
                element = i * count;
                myIList.Add(element);
                expectValue[i - 1] = (int)element;
            }

            for (int j = 0; j < myIList.Count;j++ )
            {
                int current = myIList.IndexOf(myIList[j]);
                if (-1== current)
                {
                    TestLibrary.TestFramework.LogError("001.1", "calling IndexOf method return an error number.");
                    retVal = false;
                }
               
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool PosTest2()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest2: Calling IndexOf method of IList,T is reference type.");
        try
        {
            List<string> myList = new List<string>();
            int count = 10;
            string[] expectValue = new string[10];
            object element = null;
            IList myIList = ((IList)myList);
            for (int i = 1; i <= count; i++)
            {
                element = i.ToString();
                myIList.Add(element);
                expectValue[i - 1] = element.ToString();
            }
            for (int j = 0; j < myIList.Count; j++)
            {
                int current = myIList.IndexOf(myIList[j]);
                if (-1 == current)
                {
                    TestLibrary.TestFramework.LogError("002.1", "calling IndexOf method return an error number.");
                    retVal = false;
                }

            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool PosTest3()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest3: Calling IndexOf method of IList,T is reference type and the item is not exist in the List.");
        try
        {
            List<string> myList = new List<string>();
            int count = 10;
            string[] expectValue = new string[10];
            object element = null;
            IList myIList = ((IList)myList);
            for (int i = 1; i <= count; i++)
            {
                element = i.ToString();
                myIList.Add(element);
                expectValue[i - 1] = element.ToString();
            }
            for (int j = 0; j < myIList.Count; j++)
            {
                int current = myIList.IndexOf(null);
                if (-1 != current)
                {
                    TestLibrary.TestFramework.LogError("003.1", "calling IndexOf method return an error number.");
                    retVal = false;
                }

            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("003.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
 
}
