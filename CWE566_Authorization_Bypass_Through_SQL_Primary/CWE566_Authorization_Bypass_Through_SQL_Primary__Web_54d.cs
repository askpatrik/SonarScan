/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE566_Authorization_Bypass_Through_SQL_Primary__Web_54d.cs
Label Definition File: CWE566_Authorization_Bypass_Through_SQL_Primary__Web.label.xml
Template File: sources-sink-54d.tmpl.cs
*/
/*
 * @description
 * CWE: 566 Authorization Bypass through SQL primary
 * BadSource:  user id taken from url parameter
 * GoodSource: hardcoded user id
 * Sinks: writeConsole
 *    BadSink : user authorization not checked
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE566_Authorization_Bypass_Through_SQL_Primary
{
class CWE566_Authorization_Bypass_Through_SQL_Primary__Web_54d
{
#if (!OMITBAD)
    public static void BadSink(string data , HttpRequest req, HttpResponse resp)
    {
        CWE566_Authorization_Bypass_Through_SQL_Primary__Web_54e.BadSink(data , req, resp);
    }
#endif

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(string data , HttpRequest req, HttpResponse resp)
    {
        CWE566_Authorization_Bypass_Through_SQL_Primary__Web_54e.GoodG2BSink(data , req, resp);
    }
#endif
}
}
