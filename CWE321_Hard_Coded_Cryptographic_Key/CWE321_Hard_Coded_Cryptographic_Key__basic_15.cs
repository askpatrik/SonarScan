/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE321_Hard_Coded_Cryptographic_Key__basic_15.cs
Label Definition File: CWE321_Hard_Coded_Cryptographic_Key__basic.label.xml
Template File: sources-sink-15.tmpl.cs
*/
/*
* @description
* CWE: 321 Hard coded crypto key
* BadSource:  Set data to a hardcoded value
* GoodSource: Read data from the console using readLine()
* BadSink:  Use data as a cryptographic key
* Flow Variant: 15 Control flow: switch(6)
*
* */

using TestCaseSupport;
using System;

using System.Security.Cryptography;
using System.Text;
using System.IO;


namespace testcases.CWE321_Hard_Coded_Cryptographic_Key
{

class CWE321_Hard_Coded_Cryptographic_Key__basic_15 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        string data = null;
        switch (6)
        {
        case 6:
            /* FLAW: Set data to a hardcoded value */
            data = "23 ~j;asn!@#/>as";
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
            break;
        }
        if (data != null)
        {
            string stringToEncrypt = "Super secret Squirrel";
            byte[] byteCipherText = null;
            /* POTENTIAL FLAW: Use data as a cryptographic key */
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aes.CreateEncryptor(Encoding.UTF8.GetBytes(data), aes.IV);
                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(stringToEncrypt);
                        }
                        byteCipherText = msEncrypt.ToArray();
                    }
                }
            }
            IO.WriteLine(IO.ToHex(byteCipherText)); /* Write encrypted data to console */
        }
    }
#endif //omitbad
#if (!OMITGOOD)
    /* goodG2B1() - use goodsource and badsink by changing the  switch to switch(5) */
    private void GoodG2B1()
    {
        string data = null;
        switch (5)
        {
        case 6:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
            break;
        default:
            data = ""; /* Initialize data */
            /* read user input from console with readLine */
            try
            {
                /* FIX: Read data from the console using readLine() */
                data = Console.ReadLine();
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error with stream reading", exceptIO);
            }
            break;
        }
        if (data != null)
        {
            string stringToEncrypt = "Super secret Squirrel";
            byte[] byteCipherText = null;
            /* POTENTIAL FLAW: Use data as a cryptographic key */
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aes.CreateEncryptor(Encoding.UTF8.GetBytes(data), aes.IV);
                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(stringToEncrypt);
                        }
                        byteCipherText = msEncrypt.ToArray();
                    }
                }
            }
            IO.WriteLine(IO.ToHex(byteCipherText)); /* Write encrypted data to console */
        }
    }

    /* GoodG2B2() - use goodsource and badsink by reversing the blocks in the switch  */
    private void GoodG2B2()
    {
        string data = null;
        switch (6)
        {
        case 6:
            data = ""; /* Initialize data */
            /* read user input from console with readLine */
            try
            {
                /* FIX: Read data from the console using readLine() */
                data = Console.ReadLine();
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error with stream reading", exceptIO);
            }
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
            break;
        }
        if (data != null)
        {
            string stringToEncrypt = "Super secret Squirrel";
            byte[] byteCipherText = null;
            /* POTENTIAL FLAW: Use data as a cryptographic key */
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aes.CreateEncryptor(Encoding.UTF8.GetBytes(data), aes.IV);
                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(stringToEncrypt);
                        }
                        byteCipherText = msEncrypt.ToArray();
                    }
                }
            }
            IO.WriteLine(IO.ToHex(byteCipherText)); /* Write encrypted data to console */
        }
    }

    public override void Good()
    {
        GoodG2B1();
        GoodG2B2();
    }
#endif //omitgood
}
}
