/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Short_rand_multiply_61b.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-61b.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an overflow before multiplying data by 2
 *    BadSink : If data is positive, multiply by 2, which can cause an overflow
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Short_rand_multiply_61b
{
#if (!OMITBAD)
    public static short BadSource()
    {
        short data;
        /* POTENTIAL FLAW: Use a random value */
        data = (short)(new Random().Next(short.MinValue, short.MaxValue));
        return data;
    }
#endif

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static short GoodG2BSource()
    {
        short data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        return data;
    }

    /* goodB2G() - use badsource and goodsink */
    public static short GoodB2GSource()
    {
        short data;
        /* POTENTIAL FLAW: Use a random value */
        data = (short)(new Random().Next(short.MinValue, short.MaxValue));
        return data;
    }
#endif
}
}
