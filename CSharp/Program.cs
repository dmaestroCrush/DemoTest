using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using iDiTect.Converter;
using Microsoft.SharePoint;
using System.Xml;

namespace CSharp
{
	class Program
	{
		public int Id { get; set; }
		static void Main(string[] args)
		{
			#region palindrome
			//Console.WriteLine("\n >>>> To Find a Number is Palindrome or not <<<< ");		
			//	Console.Write("\n Enter a number: ");
			//	string num = Console.ReadLine();
			//	Console.WriteLine();
			//	var isNumeric = int.TryParse(num, out int n);


			//if (isNumeric)
			//	{
			//	//IsPalindrome(n);
			//	int[] FibSeries=FibonacciSeries(n);
			//	for (int i = 0; i < FibSeries.Length; i++)
			//	{
			//		Console.Write(FibSeries[i]+" ");
			//	}

			//		Console.ReadLine();
			//	}
			//	else
			//	{
			//		Console.WriteLine(">>>>Error Occured<<<<\n Enter a valid number");

			//	}

			#endregion

			#region Collection has value

			//int[] arr = new int[]{ -3, 1, 2,5,4, 9 };
			//int k = 6;

			//int left = 0;
			//int right = arr.Length - 1;
			//int sum = 0;
			//int count=0;
			//while (left < right)
			//{

			//	count++;
			//	sum = arr[left] + arr[right];
			//	if (sum == k)
			//	{
			//		Console.WriteLine(arr[left] + "  " + arr[right]);
			//		left = left + 1;
			//		right = right - 1;
			//	}
			//	else if (sum < k)
			//	{
			//		left = left + 1;
			//	}
			//	else if (sum > k)

			//		right = right - 1;
			//}
			//Console.WriteLine("Count = "+count);
			//Console.Read();
			#endregion

			//int b = 12;
			////subtractValue(ref  b);
			//subtractValue(b);
			//Console.WriteLine("Value of b after " +
			//"subtration operation is {0}", b);

			//	Console.WriteLine(javaString("iAmStrongCoder"));


			//int[] arr = new int[3] { 1, 2, 1 };
			//Console.WriteLine(IsOccurencesGreater(3,arr));

			#region html to Doc Convert Iditect
			//HtmlToDocxConverter converter = new HtmlToDocxConverter();

			////string htmlFilePath = @"D:\VS Projects\CSharp\index.html";
			//string htmlContent = File.ReadAllText("sample.html");
			////Define the css for the html content
			////converter.DefaultStyleSheet = ".para{font-size: 24px; color: #FF0000;}";

			////string htmlContent = "<p class=\"para\">Content with special style.</p><p>Content without style</p>";
			//converter.Load(htmlContent);

			////File.WriteAllBytes(@"D:\VS Projects\CSharp\converte.docx", converter.SaveAsBytes());

			////Convert html to Word, and save it to local file
			//using (var stream = File.OpenWrite(@"D:\VS Projects\CSharp\convertt.docx"))
			//{
			//	converter.Save(stream);
			//}
			#endregion

			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load(@"XMLFile1.xml");
			XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/TimerJobConfig");
			string siteurl = "", sourceurl = "", destinationurl = "";
			foreach (XmlNode node in nodeList)
			{
				siteurl = node.SelectSingleNode("siteurl").InnerText;
				sourceurl = node.SelectSingleNode("sourceFolder").InnerText;
				destinationurl = node.SelectSingleNode("destinationfolder").InnerText;
			}
			Console.WriteLine("SiteURL = {0}, SourceUrl= {1} , DestinationUrl = {2}", siteurl, sourceurl, destinationurl);

		}
		public static int IsOccurencesGreater(int input1,int[] input)
		{
			int counti0 = 1;
			for (int i = 0; i < input1; i++)
			{
				//int count = 0;
				for (int j = i+1; j < input1; j++)
				{
					if (input[i]==input[j])
					{
						if (i == 0)
						{
							counti0++;
						}
						
					}
					else
					{
						continue;
					}
				}
			}
			if (counti0>(input1/2))
			{
				return 1;
			}
			else
			{
				return -1;
			}
		}
		public static string javaString(string input1)
		{
			string output1 = input1[0]+"";
			for (int i = 1; i < input1.Length; i++)
			{
				if (char.IsUpper(input1[i]))
				{
					output1 += "_" + char.ToLower(input1[i]);
				}
				else
				{
					output1 += input1[i];
				}
				
			}
			return output1;
		}

		public static void subtractValue(int b)
		{
			b -= 5;
		}

		public static int[] FibonacciSeries(int length)
		{
			int[] series = new int[length];
			series[0] = 0;
			series[1] = 1;
			for (int i = 2; i < length; i++)
			{
				series[i] = series[i - 2] + series[i - 1];
			}
			return series;

		}
		public static bool IsPalindrome(int number)
		{
			int sum=0, rem,temp;
			temp = number;
			while (number > 0)
			{
				rem = number % 10; //for getting remainder by dividing with 10    
				number = number / 10; //for getting quotient by dividing with 10    
				sum = sum * 10 + rem;
				/*multiplying the sum with 10 and adding  
				remainder*/
			}
			Console.WriteLine("\n The Reversed Number is: {0} ", sum);
			if (temp != sum) //checking whether the reversed number is equal to entered number    
			{
				return false;
			}
			
			return true;
		}
	}
	
}
