using System;
using NUnit.Framework;

/* NOTE:  My main objective was to write new tests QUICKLY.
 * Code readability was compromised a bit (short variable names) in order keep everything short and sweet!
 *
 * By the way, I found .NET Fiddle's "Script" Project Type to be useful when checking out and composing Test Cases.
*/

public class ConcatQuiz
{
	public static void p(string Msg = "")
	{
		Console.WriteLine(Msg);
	}

	public static void pq(string Msg)
	{
		Console.WriteLine(Msg +" ?");
	}

	public static void ConsPrintQ(string Msg)
	{
		Console.WriteLine("Console.WriteLine(" + Msg +") ?");
	}	
	
	public static void Main()
	{
		int		qcounter = 0; // The question counter
		int 	iAns = 0;
		double	dAns = 0;
		string	sAns = "";
		string	str	 = "";
		
		p("What is the result of");
		p("---------------------" +"\n");

		str	= "99+3";
		ConsPrintQ(str);		
		iAns	= int.Parse(Console.ReadLine());
		Assert.AreEqual(99+3, iAns, "Question " + (++qcounter));
		p();
		
		str	= @"""cat""+""fish""";		// With a literal string I only have to escape double quotes with a double quote.
										// Thanks to: http://www.codeproject.com/Articles/371232/Escaping-in-Csharp-characters-strings-string-forma
		ConsPrintQ(str);		
		sAns	= (string)Console.ReadLine();
		Assert.AreEqual("cat"+"fish", sAns, "Question " + (++qcounter));
		//// Assert.That( str, Is.EqualTo(sAns), "Question " + (++qcounter));
		p();
		
		str = @"9+3 + ""cat""";
		ConsPrintQ(str);		
		sAns	= Console.ReadLine();
		Assert.AreEqual(9+3+"cat", sAns, "Question " + (++qcounter));		
		p();
		
		str = @"""cat"" +3+9";
		ConsPrintQ(str);		
		sAns	= Console.ReadLine();
		Assert.AreEqual("cat"+3+9, sAns, "Question " + (++qcounter));
		p();
		
		str = @"""cat"" +(3+9)";
		ConsPrintQ(str);		
		sAns	= Console.ReadLine();
		Assert.AreEqual("cat"+(3+9), sAns, "Question " + (++qcounter));
		p();
		
		str = @"""You must insert at least "" + (10 -3) + "" cents.""";
		ConsPrintQ(str);		
		sAns	= Console.ReadLine();
		Assert.AreEqual("You must insert at least " +(10 -3) + " cents.", sAns, "Question " + (++qcounter));
		p();
		p("NOTE: This will not compile in C# !!!!!! Do you know WHY?");
		p(@"Console.WriteLine(""You must insert at least "" + 10 -3 + "" cents."")");
		p();
		
		str = @"""DoG"" +9 +"" "" +""wo"" + ""of"" ";
		ConsPrintQ(str);		
		sAns	= Console.ReadLine();
		Assert.AreEqual("DoG" +9 +" " +"wo" + "of", sAns, "Question " + (++qcounter));
		p();
		
		p(" *** WELL DONE *** !!!");
	}
}
