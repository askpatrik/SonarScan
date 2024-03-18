/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE601_Open_Redirect__Web_Params_Get_Web_52b.cs
Label Definition File: CWE601_Open_Redirect__Web.label.xml
Template File: sources-sink-52b.tmpl.cs
*/
/*
 * @description
 * CWE: 601 Open Redirect
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : place redirect string directly into redirect api call
 * Flow Variant: 52 Data flow: data passed as an argument from one method to another to another in three different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE601_Open_Redirect
{
class CWE601_Open_Redirect__Web_Params_Get_Web_52b
{
#if (!OMITBAD)
    public static void BadSink(string data , HttpRequest req, HttpResponse resp)
    {
        CWE601_Open_Redirect__Web_Params_Get_Web_52c.BadSink(data , req, resp);
    }
#endif

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(string data , HttpRequest req, HttpResponse resp)
    {
        CWE601_Open_Redirect__Web_Params_Get_Web_52c.GoodG2BSink(data , req, resp);
    }
#endif
}
}