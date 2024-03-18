using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;

namespace testcases.CWE90_LDAP_Injection
{
	class Program {

		static void Main(string[] args) {
			
			if(args.Any()) {
			
				if(args[0].Equals("-h", StringComparison.OrdinalIgnoreCase) || 
                   args[0].Equals("--help", StringComparison.OrdinalIgnoreCase)) {
			
					Console.WriteLine("To use this main, you can either run the program with no " +
					"command line arguments to run all test cases or you can specify one or more classes to test");
					System.Environment.Exit(1);
				}
				
				/* User supplied some class names on the command line, just use those with introspection
				 *
				 * string classNames[] = { "CWE481_Assigning_instead_of_Comparing__boolean_01",
				 *		"CWE476_Null_Pointer_Dereference__getProperty_01" };
				 * could read class names from command line or use
				 * http://sadun-util.sourceforge.net/api/org/sadun/util/
				 * ClassPackageExplorer.html
				 */

				foreach (string className in args) {

					try {
						
						/* String classNameWithPackage = "testcases." + className; */
						
						/* Console.WriteLine("classNameWithPackage = " + classNameWithPackage); */

						Type myClass = Type.GetType(className);
						object myObject = Activator.CreateInstance(myClass);
						myClass.InvokeMember("runTest", 
							BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public, 
							null, 
							myObject, 
							new object[] { className });

					} catch (Exception ex) {

						Console.WriteLine("Could not run test for class " + className);
						Console.WriteLine(ex.StackTrace);

					}
					
					Console.WriteLine(""); /* leave a blank line between classes */

				}

			} else {
			
				/* No command line args were used, we want to run every testcase */
				
				/* needed to separate these calls into other methods because
				   we were running into the size limit Java has for a single method */
				RunTestCWE1();
				RunTestCWE2();
				RunTestCWE3();
				RunTestCWE4();
				RunTestCWE5();
				RunTestCWE6();
				RunTestCWE7();
				RunTestCWE8();
				RunTestCWE9();
			}			
		}

	private static void RunTestCWE1() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-1 */

			/* END-AUTOGENERATED-CSHARP-TESTS-1 */
	}

	private static void RunTestCWE2() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-2 */

			/* END-AUTOGENERATED-CSHARP-TESTS-2 */
	}

	private static void RunTestCWE3() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-3 */

			/* END-AUTOGENERATED-CSHARP-TESTS-3 */
	}

	private static void RunTestCWE4() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-4 */

			/* END-AUTOGENERATED-CSHARP-TESTS-4 */
	}

	private static void RunTestCWE5() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-5 */

			/* END-AUTOGENERATED-CSHARP-TESTS-5 */
	}

	private static void RunTestCWE6() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-6 */

			/* END-AUTOGENERATED-CSHARP-TESTS-6 */
	}

	private static void RunTestCWE7() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-7 */

			/* END-AUTOGENERATED-CSHARP-TESTS-7 */
	}

	private static void RunTestCWE8() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-8 */

			/* END-AUTOGENERATED-CSHARP-TESTS-8 */
	}

	private static void RunTestCWE9() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-9 */
			(new CWE90_LDAP_Injection__Connect_tcp_01()).RunTest("CWE90_LDAP_Injection__Connect_tcp_01");
			(new CWE90_LDAP_Injection__Connect_tcp_02()).RunTest("CWE90_LDAP_Injection__Connect_tcp_02");
			(new CWE90_LDAP_Injection__Connect_tcp_03()).RunTest("CWE90_LDAP_Injection__Connect_tcp_03");
			(new CWE90_LDAP_Injection__Connect_tcp_04()).RunTest("CWE90_LDAP_Injection__Connect_tcp_04");
			(new CWE90_LDAP_Injection__Connect_tcp_05()).RunTest("CWE90_LDAP_Injection__Connect_tcp_05");
			(new CWE90_LDAP_Injection__Connect_tcp_06()).RunTest("CWE90_LDAP_Injection__Connect_tcp_06");
			(new CWE90_LDAP_Injection__Connect_tcp_07()).RunTest("CWE90_LDAP_Injection__Connect_tcp_07");
			(new CWE90_LDAP_Injection__Connect_tcp_08()).RunTest("CWE90_LDAP_Injection__Connect_tcp_08");
			(new CWE90_LDAP_Injection__Connect_tcp_09()).RunTest("CWE90_LDAP_Injection__Connect_tcp_09");
			(new CWE90_LDAP_Injection__Connect_tcp_10()).RunTest("CWE90_LDAP_Injection__Connect_tcp_10");
			(new CWE90_LDAP_Injection__Connect_tcp_11()).RunTest("CWE90_LDAP_Injection__Connect_tcp_11");
			(new CWE90_LDAP_Injection__Connect_tcp_12()).RunTest("CWE90_LDAP_Injection__Connect_tcp_12");
			(new CWE90_LDAP_Injection__Connect_tcp_13()).RunTest("CWE90_LDAP_Injection__Connect_tcp_13");
			(new CWE90_LDAP_Injection__Connect_tcp_14()).RunTest("CWE90_LDAP_Injection__Connect_tcp_14");
			(new CWE90_LDAP_Injection__Connect_tcp_15()).RunTest("CWE90_LDAP_Injection__Connect_tcp_15");
			(new CWE90_LDAP_Injection__Connect_tcp_16()).RunTest("CWE90_LDAP_Injection__Connect_tcp_16");
			(new CWE90_LDAP_Injection__Connect_tcp_17()).RunTest("CWE90_LDAP_Injection__Connect_tcp_17");
			(new CWE90_LDAP_Injection__Connect_tcp_21()).RunTest("CWE90_LDAP_Injection__Connect_tcp_21");
			(new CWE90_LDAP_Injection__Connect_tcp_22a()).RunTest("CWE90_LDAP_Injection__Connect_tcp_22a");
			(new CWE90_LDAP_Injection__Connect_tcp_31()).RunTest("CWE90_LDAP_Injection__Connect_tcp_31");
			(new CWE90_LDAP_Injection__Connect_tcp_41()).RunTest("CWE90_LDAP_Injection__Connect_tcp_41");
			(new CWE90_LDAP_Injection__Connect_tcp_42()).RunTest("CWE90_LDAP_Injection__Connect_tcp_42");
			(new CWE90_LDAP_Injection__Connect_tcp_45()).RunTest("CWE90_LDAP_Injection__Connect_tcp_45");
			(new CWE90_LDAP_Injection__Connect_tcp_51a()).RunTest("CWE90_LDAP_Injection__Connect_tcp_51a");
			(new CWE90_LDAP_Injection__Connect_tcp_52a()).RunTest("CWE90_LDAP_Injection__Connect_tcp_52a");
			(new CWE90_LDAP_Injection__Connect_tcp_53a()).RunTest("CWE90_LDAP_Injection__Connect_tcp_53a");
			(new CWE90_LDAP_Injection__Connect_tcp_54a()).RunTest("CWE90_LDAP_Injection__Connect_tcp_54a");
			(new CWE90_LDAP_Injection__Connect_tcp_61a()).RunTest("CWE90_LDAP_Injection__Connect_tcp_61a");
			(new CWE90_LDAP_Injection__Connect_tcp_66a()).RunTest("CWE90_LDAP_Injection__Connect_tcp_66a");
			(new CWE90_LDAP_Injection__Connect_tcp_67a()).RunTest("CWE90_LDAP_Injection__Connect_tcp_67a");
			(new CWE90_LDAP_Injection__Connect_tcp_68a()).RunTest("CWE90_LDAP_Injection__Connect_tcp_68a");
			(new CWE90_LDAP_Injection__Connect_tcp_71a()).RunTest("CWE90_LDAP_Injection__Connect_tcp_71a");
			(new CWE90_LDAP_Injection__Connect_tcp_72a()).RunTest("CWE90_LDAP_Injection__Connect_tcp_72a");
			(new CWE90_LDAP_Injection__Connect_tcp_73a()).RunTest("CWE90_LDAP_Injection__Connect_tcp_73a");
			(new CWE90_LDAP_Injection__Connect_tcp_74a()).RunTest("CWE90_LDAP_Injection__Connect_tcp_74a");
			(new CWE90_LDAP_Injection__Connect_tcp_75a()).RunTest("CWE90_LDAP_Injection__Connect_tcp_75a");
			(new CWE90_LDAP_Injection__Connect_tcp_81a()).RunTest("CWE90_LDAP_Injection__Connect_tcp_81a");
			(new CWE90_LDAP_Injection__Database_01()).RunTest("CWE90_LDAP_Injection__Database_01");
			(new CWE90_LDAP_Injection__Database_02()).RunTest("CWE90_LDAP_Injection__Database_02");
			(new CWE90_LDAP_Injection__Database_03()).RunTest("CWE90_LDAP_Injection__Database_03");
			(new CWE90_LDAP_Injection__Database_04()).RunTest("CWE90_LDAP_Injection__Database_04");
			(new CWE90_LDAP_Injection__Database_05()).RunTest("CWE90_LDAP_Injection__Database_05");
			(new CWE90_LDAP_Injection__Database_06()).RunTest("CWE90_LDAP_Injection__Database_06");
			(new CWE90_LDAP_Injection__Database_07()).RunTest("CWE90_LDAP_Injection__Database_07");
			(new CWE90_LDAP_Injection__Database_08()).RunTest("CWE90_LDAP_Injection__Database_08");
			(new CWE90_LDAP_Injection__Database_09()).RunTest("CWE90_LDAP_Injection__Database_09");
			(new CWE90_LDAP_Injection__Database_10()).RunTest("CWE90_LDAP_Injection__Database_10");
			(new CWE90_LDAP_Injection__Database_11()).RunTest("CWE90_LDAP_Injection__Database_11");
			(new CWE90_LDAP_Injection__Database_12()).RunTest("CWE90_LDAP_Injection__Database_12");
			(new CWE90_LDAP_Injection__Database_13()).RunTest("CWE90_LDAP_Injection__Database_13");
			(new CWE90_LDAP_Injection__Database_14()).RunTest("CWE90_LDAP_Injection__Database_14");
			(new CWE90_LDAP_Injection__Database_15()).RunTest("CWE90_LDAP_Injection__Database_15");
			(new CWE90_LDAP_Injection__Database_16()).RunTest("CWE90_LDAP_Injection__Database_16");
			(new CWE90_LDAP_Injection__Database_17()).RunTest("CWE90_LDAP_Injection__Database_17");
			(new CWE90_LDAP_Injection__Database_21()).RunTest("CWE90_LDAP_Injection__Database_21");
			(new CWE90_LDAP_Injection__Database_22a()).RunTest("CWE90_LDAP_Injection__Database_22a");
			(new CWE90_LDAP_Injection__Database_31()).RunTest("CWE90_LDAP_Injection__Database_31");
			(new CWE90_LDAP_Injection__Database_41()).RunTest("CWE90_LDAP_Injection__Database_41");
			(new CWE90_LDAP_Injection__Database_42()).RunTest("CWE90_LDAP_Injection__Database_42");
			(new CWE90_LDAP_Injection__Database_45()).RunTest("CWE90_LDAP_Injection__Database_45");
			(new CWE90_LDAP_Injection__Database_51a()).RunTest("CWE90_LDAP_Injection__Database_51a");
			(new CWE90_LDAP_Injection__Database_52a()).RunTest("CWE90_LDAP_Injection__Database_52a");
			(new CWE90_LDAP_Injection__Database_53a()).RunTest("CWE90_LDAP_Injection__Database_53a");
			(new CWE90_LDAP_Injection__Database_54a()).RunTest("CWE90_LDAP_Injection__Database_54a");
			(new CWE90_LDAP_Injection__Database_61a()).RunTest("CWE90_LDAP_Injection__Database_61a");
			(new CWE90_LDAP_Injection__Database_66a()).RunTest("CWE90_LDAP_Injection__Database_66a");
			(new CWE90_LDAP_Injection__Database_67a()).RunTest("CWE90_LDAP_Injection__Database_67a");
			(new CWE90_LDAP_Injection__Database_68a()).RunTest("CWE90_LDAP_Injection__Database_68a");
			(new CWE90_LDAP_Injection__Database_71a()).RunTest("CWE90_LDAP_Injection__Database_71a");
			(new CWE90_LDAP_Injection__Database_72a()).RunTest("CWE90_LDAP_Injection__Database_72a");
			(new CWE90_LDAP_Injection__Database_73a()).RunTest("CWE90_LDAP_Injection__Database_73a");
			(new CWE90_LDAP_Injection__Database_74a()).RunTest("CWE90_LDAP_Injection__Database_74a");
			(new CWE90_LDAP_Injection__Database_75a()).RunTest("CWE90_LDAP_Injection__Database_75a");
			(new CWE90_LDAP_Injection__Database_81a()).RunTest("CWE90_LDAP_Injection__Database_81a");
			(new CWE90_LDAP_Injection__Environment_01()).RunTest("CWE90_LDAP_Injection__Environment_01");
			(new CWE90_LDAP_Injection__Environment_02()).RunTest("CWE90_LDAP_Injection__Environment_02");
			(new CWE90_LDAP_Injection__Environment_03()).RunTest("CWE90_LDAP_Injection__Environment_03");
			(new CWE90_LDAP_Injection__Environment_04()).RunTest("CWE90_LDAP_Injection__Environment_04");
			(new CWE90_LDAP_Injection__Environment_05()).RunTest("CWE90_LDAP_Injection__Environment_05");
			(new CWE90_LDAP_Injection__Environment_06()).RunTest("CWE90_LDAP_Injection__Environment_06");
			(new CWE90_LDAP_Injection__Environment_07()).RunTest("CWE90_LDAP_Injection__Environment_07");
			(new CWE90_LDAP_Injection__Environment_08()).RunTest("CWE90_LDAP_Injection__Environment_08");
			(new CWE90_LDAP_Injection__Environment_09()).RunTest("CWE90_LDAP_Injection__Environment_09");
			(new CWE90_LDAP_Injection__Environment_10()).RunTest("CWE90_LDAP_Injection__Environment_10");
			(new CWE90_LDAP_Injection__Environment_11()).RunTest("CWE90_LDAP_Injection__Environment_11");
			(new CWE90_LDAP_Injection__Environment_12()).RunTest("CWE90_LDAP_Injection__Environment_12");
			(new CWE90_LDAP_Injection__Environment_13()).RunTest("CWE90_LDAP_Injection__Environment_13");
			(new CWE90_LDAP_Injection__Environment_14()).RunTest("CWE90_LDAP_Injection__Environment_14");
			(new CWE90_LDAP_Injection__Environment_15()).RunTest("CWE90_LDAP_Injection__Environment_15");
			(new CWE90_LDAP_Injection__Environment_16()).RunTest("CWE90_LDAP_Injection__Environment_16");
			(new CWE90_LDAP_Injection__Environment_17()).RunTest("CWE90_LDAP_Injection__Environment_17");
			(new CWE90_LDAP_Injection__Environment_21()).RunTest("CWE90_LDAP_Injection__Environment_21");
			(new CWE90_LDAP_Injection__Environment_22a()).RunTest("CWE90_LDAP_Injection__Environment_22a");
			(new CWE90_LDAP_Injection__Environment_31()).RunTest("CWE90_LDAP_Injection__Environment_31");
			(new CWE90_LDAP_Injection__Environment_41()).RunTest("CWE90_LDAP_Injection__Environment_41");
			(new CWE90_LDAP_Injection__Environment_42()).RunTest("CWE90_LDAP_Injection__Environment_42");
			(new CWE90_LDAP_Injection__Environment_45()).RunTest("CWE90_LDAP_Injection__Environment_45");
			(new CWE90_LDAP_Injection__Environment_51a()).RunTest("CWE90_LDAP_Injection__Environment_51a");
			(new CWE90_LDAP_Injection__Environment_52a()).RunTest("CWE90_LDAP_Injection__Environment_52a");
			(new CWE90_LDAP_Injection__Environment_53a()).RunTest("CWE90_LDAP_Injection__Environment_53a");
			(new CWE90_LDAP_Injection__Environment_54a()).RunTest("CWE90_LDAP_Injection__Environment_54a");
			(new CWE90_LDAP_Injection__Environment_61a()).RunTest("CWE90_LDAP_Injection__Environment_61a");
			(new CWE90_LDAP_Injection__Environment_66a()).RunTest("CWE90_LDAP_Injection__Environment_66a");
			(new CWE90_LDAP_Injection__Environment_67a()).RunTest("CWE90_LDAP_Injection__Environment_67a");
			(new CWE90_LDAP_Injection__Environment_68a()).RunTest("CWE90_LDAP_Injection__Environment_68a");
			(new CWE90_LDAP_Injection__Environment_71a()).RunTest("CWE90_LDAP_Injection__Environment_71a");
			(new CWE90_LDAP_Injection__Environment_72a()).RunTest("CWE90_LDAP_Injection__Environment_72a");
			(new CWE90_LDAP_Injection__Environment_73a()).RunTest("CWE90_LDAP_Injection__Environment_73a");
			(new CWE90_LDAP_Injection__Environment_74a()).RunTest("CWE90_LDAP_Injection__Environment_74a");
			(new CWE90_LDAP_Injection__Environment_75a()).RunTest("CWE90_LDAP_Injection__Environment_75a");
			(new CWE90_LDAP_Injection__Environment_81a()).RunTest("CWE90_LDAP_Injection__Environment_81a");
			(new CWE90_LDAP_Injection__File_01()).RunTest("CWE90_LDAP_Injection__File_01");
			(new CWE90_LDAP_Injection__File_02()).RunTest("CWE90_LDAP_Injection__File_02");
			(new CWE90_LDAP_Injection__File_03()).RunTest("CWE90_LDAP_Injection__File_03");
			(new CWE90_LDAP_Injection__File_04()).RunTest("CWE90_LDAP_Injection__File_04");
			(new CWE90_LDAP_Injection__File_05()).RunTest("CWE90_LDAP_Injection__File_05");
			(new CWE90_LDAP_Injection__File_06()).RunTest("CWE90_LDAP_Injection__File_06");
			(new CWE90_LDAP_Injection__File_07()).RunTest("CWE90_LDAP_Injection__File_07");
			(new CWE90_LDAP_Injection__File_08()).RunTest("CWE90_LDAP_Injection__File_08");
			(new CWE90_LDAP_Injection__File_09()).RunTest("CWE90_LDAP_Injection__File_09");
			(new CWE90_LDAP_Injection__File_10()).RunTest("CWE90_LDAP_Injection__File_10");
			(new CWE90_LDAP_Injection__File_11()).RunTest("CWE90_LDAP_Injection__File_11");
			(new CWE90_LDAP_Injection__File_12()).RunTest("CWE90_LDAP_Injection__File_12");
			(new CWE90_LDAP_Injection__File_13()).RunTest("CWE90_LDAP_Injection__File_13");
			(new CWE90_LDAP_Injection__File_14()).RunTest("CWE90_LDAP_Injection__File_14");
			(new CWE90_LDAP_Injection__File_15()).RunTest("CWE90_LDAP_Injection__File_15");
			(new CWE90_LDAP_Injection__File_16()).RunTest("CWE90_LDAP_Injection__File_16");
			(new CWE90_LDAP_Injection__File_17()).RunTest("CWE90_LDAP_Injection__File_17");
			(new CWE90_LDAP_Injection__File_21()).RunTest("CWE90_LDAP_Injection__File_21");
			(new CWE90_LDAP_Injection__File_22a()).RunTest("CWE90_LDAP_Injection__File_22a");
			(new CWE90_LDAP_Injection__File_31()).RunTest("CWE90_LDAP_Injection__File_31");
			(new CWE90_LDAP_Injection__File_41()).RunTest("CWE90_LDAP_Injection__File_41");
			(new CWE90_LDAP_Injection__File_42()).RunTest("CWE90_LDAP_Injection__File_42");
			(new CWE90_LDAP_Injection__File_45()).RunTest("CWE90_LDAP_Injection__File_45");
			(new CWE90_LDAP_Injection__File_51a()).RunTest("CWE90_LDAP_Injection__File_51a");
			(new CWE90_LDAP_Injection__File_52a()).RunTest("CWE90_LDAP_Injection__File_52a");
			(new CWE90_LDAP_Injection__File_53a()).RunTest("CWE90_LDAP_Injection__File_53a");
			(new CWE90_LDAP_Injection__File_54a()).RunTest("CWE90_LDAP_Injection__File_54a");
			(new CWE90_LDAP_Injection__File_61a()).RunTest("CWE90_LDAP_Injection__File_61a");
			(new CWE90_LDAP_Injection__File_66a()).RunTest("CWE90_LDAP_Injection__File_66a");
			(new CWE90_LDAP_Injection__File_67a()).RunTest("CWE90_LDAP_Injection__File_67a");
			(new CWE90_LDAP_Injection__File_68a()).RunTest("CWE90_LDAP_Injection__File_68a");
			(new CWE90_LDAP_Injection__File_71a()).RunTest("CWE90_LDAP_Injection__File_71a");
			(new CWE90_LDAP_Injection__File_72a()).RunTest("CWE90_LDAP_Injection__File_72a");
			(new CWE90_LDAP_Injection__File_73a()).RunTest("CWE90_LDAP_Injection__File_73a");
			(new CWE90_LDAP_Injection__File_74a()).RunTest("CWE90_LDAP_Injection__File_74a");
			(new CWE90_LDAP_Injection__File_75a()).RunTest("CWE90_LDAP_Injection__File_75a");
			(new CWE90_LDAP_Injection__File_81a()).RunTest("CWE90_LDAP_Injection__File_81a");
			(new CWE90_LDAP_Injection__Listen_tcp_01()).RunTest("CWE90_LDAP_Injection__Listen_tcp_01");
			(new CWE90_LDAP_Injection__Listen_tcp_02()).RunTest("CWE90_LDAP_Injection__Listen_tcp_02");
			(new CWE90_LDAP_Injection__Listen_tcp_03()).RunTest("CWE90_LDAP_Injection__Listen_tcp_03");
			(new CWE90_LDAP_Injection__Listen_tcp_04()).RunTest("CWE90_LDAP_Injection__Listen_tcp_04");
			(new CWE90_LDAP_Injection__Listen_tcp_05()).RunTest("CWE90_LDAP_Injection__Listen_tcp_05");
			(new CWE90_LDAP_Injection__Listen_tcp_06()).RunTest("CWE90_LDAP_Injection__Listen_tcp_06");
			(new CWE90_LDAP_Injection__Listen_tcp_07()).RunTest("CWE90_LDAP_Injection__Listen_tcp_07");
			(new CWE90_LDAP_Injection__Listen_tcp_08()).RunTest("CWE90_LDAP_Injection__Listen_tcp_08");
			(new CWE90_LDAP_Injection__Listen_tcp_09()).RunTest("CWE90_LDAP_Injection__Listen_tcp_09");
			(new CWE90_LDAP_Injection__Listen_tcp_10()).RunTest("CWE90_LDAP_Injection__Listen_tcp_10");
			(new CWE90_LDAP_Injection__Listen_tcp_11()).RunTest("CWE90_LDAP_Injection__Listen_tcp_11");
			(new CWE90_LDAP_Injection__Listen_tcp_12()).RunTest("CWE90_LDAP_Injection__Listen_tcp_12");
			(new CWE90_LDAP_Injection__Listen_tcp_13()).RunTest("CWE90_LDAP_Injection__Listen_tcp_13");
			(new CWE90_LDAP_Injection__Listen_tcp_14()).RunTest("CWE90_LDAP_Injection__Listen_tcp_14");
			(new CWE90_LDAP_Injection__Listen_tcp_15()).RunTest("CWE90_LDAP_Injection__Listen_tcp_15");
			(new CWE90_LDAP_Injection__Listen_tcp_16()).RunTest("CWE90_LDAP_Injection__Listen_tcp_16");
			(new CWE90_LDAP_Injection__Listen_tcp_17()).RunTest("CWE90_LDAP_Injection__Listen_tcp_17");
			(new CWE90_LDAP_Injection__Listen_tcp_21()).RunTest("CWE90_LDAP_Injection__Listen_tcp_21");
			(new CWE90_LDAP_Injection__Listen_tcp_22a()).RunTest("CWE90_LDAP_Injection__Listen_tcp_22a");
			(new CWE90_LDAP_Injection__Listen_tcp_31()).RunTest("CWE90_LDAP_Injection__Listen_tcp_31");
			(new CWE90_LDAP_Injection__Listen_tcp_41()).RunTest("CWE90_LDAP_Injection__Listen_tcp_41");
			(new CWE90_LDAP_Injection__Listen_tcp_42()).RunTest("CWE90_LDAP_Injection__Listen_tcp_42");
			(new CWE90_LDAP_Injection__Listen_tcp_45()).RunTest("CWE90_LDAP_Injection__Listen_tcp_45");
			(new CWE90_LDAP_Injection__Listen_tcp_51a()).RunTest("CWE90_LDAP_Injection__Listen_tcp_51a");
			(new CWE90_LDAP_Injection__Listen_tcp_52a()).RunTest("CWE90_LDAP_Injection__Listen_tcp_52a");
			(new CWE90_LDAP_Injection__Listen_tcp_53a()).RunTest("CWE90_LDAP_Injection__Listen_tcp_53a");
			(new CWE90_LDAP_Injection__Listen_tcp_54a()).RunTest("CWE90_LDAP_Injection__Listen_tcp_54a");
			(new CWE90_LDAP_Injection__Listen_tcp_61a()).RunTest("CWE90_LDAP_Injection__Listen_tcp_61a");
			(new CWE90_LDAP_Injection__Listen_tcp_66a()).RunTest("CWE90_LDAP_Injection__Listen_tcp_66a");
			(new CWE90_LDAP_Injection__Listen_tcp_67a()).RunTest("CWE90_LDAP_Injection__Listen_tcp_67a");
			(new CWE90_LDAP_Injection__Listen_tcp_68a()).RunTest("CWE90_LDAP_Injection__Listen_tcp_68a");
			(new CWE90_LDAP_Injection__Listen_tcp_71a()).RunTest("CWE90_LDAP_Injection__Listen_tcp_71a");
			(new CWE90_LDAP_Injection__Listen_tcp_72a()).RunTest("CWE90_LDAP_Injection__Listen_tcp_72a");
			(new CWE90_LDAP_Injection__Listen_tcp_73a()).RunTest("CWE90_LDAP_Injection__Listen_tcp_73a");
			(new CWE90_LDAP_Injection__Listen_tcp_74a()).RunTest("CWE90_LDAP_Injection__Listen_tcp_74a");
			(new CWE90_LDAP_Injection__Listen_tcp_75a()).RunTest("CWE90_LDAP_Injection__Listen_tcp_75a");
			(new CWE90_LDAP_Injection__Listen_tcp_81a()).RunTest("CWE90_LDAP_Injection__Listen_tcp_81a");
			(new CWE90_LDAP_Injection__NetClient_01()).RunTest("CWE90_LDAP_Injection__NetClient_01");
			(new CWE90_LDAP_Injection__NetClient_02()).RunTest("CWE90_LDAP_Injection__NetClient_02");
			(new CWE90_LDAP_Injection__NetClient_03()).RunTest("CWE90_LDAP_Injection__NetClient_03");
			(new CWE90_LDAP_Injection__NetClient_04()).RunTest("CWE90_LDAP_Injection__NetClient_04");
			(new CWE90_LDAP_Injection__NetClient_05()).RunTest("CWE90_LDAP_Injection__NetClient_05");
			(new CWE90_LDAP_Injection__NetClient_06()).RunTest("CWE90_LDAP_Injection__NetClient_06");
			(new CWE90_LDAP_Injection__NetClient_07()).RunTest("CWE90_LDAP_Injection__NetClient_07");
			(new CWE90_LDAP_Injection__NetClient_08()).RunTest("CWE90_LDAP_Injection__NetClient_08");
			(new CWE90_LDAP_Injection__NetClient_09()).RunTest("CWE90_LDAP_Injection__NetClient_09");
			(new CWE90_LDAP_Injection__NetClient_10()).RunTest("CWE90_LDAP_Injection__NetClient_10");
			(new CWE90_LDAP_Injection__NetClient_11()).RunTest("CWE90_LDAP_Injection__NetClient_11");
			(new CWE90_LDAP_Injection__NetClient_12()).RunTest("CWE90_LDAP_Injection__NetClient_12");
			(new CWE90_LDAP_Injection__NetClient_13()).RunTest("CWE90_LDAP_Injection__NetClient_13");
			(new CWE90_LDAP_Injection__NetClient_14()).RunTest("CWE90_LDAP_Injection__NetClient_14");
			(new CWE90_LDAP_Injection__NetClient_15()).RunTest("CWE90_LDAP_Injection__NetClient_15");
			(new CWE90_LDAP_Injection__NetClient_16()).RunTest("CWE90_LDAP_Injection__NetClient_16");
			(new CWE90_LDAP_Injection__NetClient_17()).RunTest("CWE90_LDAP_Injection__NetClient_17");
			(new CWE90_LDAP_Injection__NetClient_21()).RunTest("CWE90_LDAP_Injection__NetClient_21");
			(new CWE90_LDAP_Injection__NetClient_22a()).RunTest("CWE90_LDAP_Injection__NetClient_22a");
			(new CWE90_LDAP_Injection__NetClient_31()).RunTest("CWE90_LDAP_Injection__NetClient_31");
			(new CWE90_LDAP_Injection__NetClient_41()).RunTest("CWE90_LDAP_Injection__NetClient_41");
			(new CWE90_LDAP_Injection__NetClient_42()).RunTest("CWE90_LDAP_Injection__NetClient_42");
			(new CWE90_LDAP_Injection__NetClient_45()).RunTest("CWE90_LDAP_Injection__NetClient_45");
			(new CWE90_LDAP_Injection__NetClient_51a()).RunTest("CWE90_LDAP_Injection__NetClient_51a");
			(new CWE90_LDAP_Injection__NetClient_52a()).RunTest("CWE90_LDAP_Injection__NetClient_52a");
			(new CWE90_LDAP_Injection__NetClient_53a()).RunTest("CWE90_LDAP_Injection__NetClient_53a");
			(new CWE90_LDAP_Injection__NetClient_54a()).RunTest("CWE90_LDAP_Injection__NetClient_54a");
			(new CWE90_LDAP_Injection__NetClient_61a()).RunTest("CWE90_LDAP_Injection__NetClient_61a");
			(new CWE90_LDAP_Injection__NetClient_66a()).RunTest("CWE90_LDAP_Injection__NetClient_66a");
			(new CWE90_LDAP_Injection__NetClient_67a()).RunTest("CWE90_LDAP_Injection__NetClient_67a");
			(new CWE90_LDAP_Injection__NetClient_68a()).RunTest("CWE90_LDAP_Injection__NetClient_68a");
			(new CWE90_LDAP_Injection__NetClient_71a()).RunTest("CWE90_LDAP_Injection__NetClient_71a");
			(new CWE90_LDAP_Injection__NetClient_72a()).RunTest("CWE90_LDAP_Injection__NetClient_72a");
			(new CWE90_LDAP_Injection__NetClient_73a()).RunTest("CWE90_LDAP_Injection__NetClient_73a");
			(new CWE90_LDAP_Injection__NetClient_74a()).RunTest("CWE90_LDAP_Injection__NetClient_74a");
			(new CWE90_LDAP_Injection__NetClient_75a()).RunTest("CWE90_LDAP_Injection__NetClient_75a");
			(new CWE90_LDAP_Injection__NetClient_81a()).RunTest("CWE90_LDAP_Injection__NetClient_81a");
			(new CWE90_LDAP_Injection__ReadLine_01()).RunTest("CWE90_LDAP_Injection__ReadLine_01");
			(new CWE90_LDAP_Injection__ReadLine_02()).RunTest("CWE90_LDAP_Injection__ReadLine_02");
			(new CWE90_LDAP_Injection__ReadLine_03()).RunTest("CWE90_LDAP_Injection__ReadLine_03");
			(new CWE90_LDAP_Injection__ReadLine_04()).RunTest("CWE90_LDAP_Injection__ReadLine_04");
			(new CWE90_LDAP_Injection__ReadLine_05()).RunTest("CWE90_LDAP_Injection__ReadLine_05");
			(new CWE90_LDAP_Injection__ReadLine_06()).RunTest("CWE90_LDAP_Injection__ReadLine_06");
			(new CWE90_LDAP_Injection__ReadLine_07()).RunTest("CWE90_LDAP_Injection__ReadLine_07");
			(new CWE90_LDAP_Injection__ReadLine_08()).RunTest("CWE90_LDAP_Injection__ReadLine_08");
			(new CWE90_LDAP_Injection__ReadLine_09()).RunTest("CWE90_LDAP_Injection__ReadLine_09");
			(new CWE90_LDAP_Injection__ReadLine_10()).RunTest("CWE90_LDAP_Injection__ReadLine_10");
			(new CWE90_LDAP_Injection__ReadLine_11()).RunTest("CWE90_LDAP_Injection__ReadLine_11");
			(new CWE90_LDAP_Injection__ReadLine_12()).RunTest("CWE90_LDAP_Injection__ReadLine_12");
			(new CWE90_LDAP_Injection__ReadLine_13()).RunTest("CWE90_LDAP_Injection__ReadLine_13");
			(new CWE90_LDAP_Injection__ReadLine_14()).RunTest("CWE90_LDAP_Injection__ReadLine_14");
			(new CWE90_LDAP_Injection__ReadLine_15()).RunTest("CWE90_LDAP_Injection__ReadLine_15");
			(new CWE90_LDAP_Injection__ReadLine_16()).RunTest("CWE90_LDAP_Injection__ReadLine_16");
			(new CWE90_LDAP_Injection__ReadLine_17()).RunTest("CWE90_LDAP_Injection__ReadLine_17");
			(new CWE90_LDAP_Injection__ReadLine_21()).RunTest("CWE90_LDAP_Injection__ReadLine_21");
			(new CWE90_LDAP_Injection__ReadLine_22a()).RunTest("CWE90_LDAP_Injection__ReadLine_22a");
			(new CWE90_LDAP_Injection__ReadLine_31()).RunTest("CWE90_LDAP_Injection__ReadLine_31");
			(new CWE90_LDAP_Injection__ReadLine_41()).RunTest("CWE90_LDAP_Injection__ReadLine_41");
			(new CWE90_LDAP_Injection__ReadLine_42()).RunTest("CWE90_LDAP_Injection__ReadLine_42");
			(new CWE90_LDAP_Injection__ReadLine_45()).RunTest("CWE90_LDAP_Injection__ReadLine_45");
			(new CWE90_LDAP_Injection__ReadLine_51a()).RunTest("CWE90_LDAP_Injection__ReadLine_51a");
			(new CWE90_LDAP_Injection__ReadLine_52a()).RunTest("CWE90_LDAP_Injection__ReadLine_52a");
			(new CWE90_LDAP_Injection__ReadLine_53a()).RunTest("CWE90_LDAP_Injection__ReadLine_53a");
			(new CWE90_LDAP_Injection__ReadLine_54a()).RunTest("CWE90_LDAP_Injection__ReadLine_54a");
			(new CWE90_LDAP_Injection__ReadLine_61a()).RunTest("CWE90_LDAP_Injection__ReadLine_61a");
			(new CWE90_LDAP_Injection__ReadLine_66a()).RunTest("CWE90_LDAP_Injection__ReadLine_66a");
			(new CWE90_LDAP_Injection__ReadLine_67a()).RunTest("CWE90_LDAP_Injection__ReadLine_67a");
			(new CWE90_LDAP_Injection__ReadLine_68a()).RunTest("CWE90_LDAP_Injection__ReadLine_68a");
			(new CWE90_LDAP_Injection__ReadLine_71a()).RunTest("CWE90_LDAP_Injection__ReadLine_71a");
			(new CWE90_LDAP_Injection__ReadLine_72a()).RunTest("CWE90_LDAP_Injection__ReadLine_72a");
			(new CWE90_LDAP_Injection__ReadLine_73a()).RunTest("CWE90_LDAP_Injection__ReadLine_73a");
			(new CWE90_LDAP_Injection__ReadLine_74a()).RunTest("CWE90_LDAP_Injection__ReadLine_74a");
			(new CWE90_LDAP_Injection__ReadLine_75a()).RunTest("CWE90_LDAP_Injection__ReadLine_75a");
			(new CWE90_LDAP_Injection__ReadLine_81a()).RunTest("CWE90_LDAP_Injection__ReadLine_81a");
			/* END-AUTOGENERATED-CSHARP-TESTS-9 */
	}
}
}