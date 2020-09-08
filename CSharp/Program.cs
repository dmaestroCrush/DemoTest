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
using SP = Microsoft.SharePoint.Client;
using System.Security;
using MsOutlook = Microsoft.Office.Interop.Outlook;
using System.Net.Mail;
using System.Net;
using System.Diagnostics;
using System.Threading;
using System.Drawing;
using System.Collections;
using System.Globalization;
using System.ComponentModel;

namespace CSharp
{
	class Employee
	{
		public int ID { get; set; }
		public string Name { get; set; }
	}
	class Program
	{
		private static Hashtable htmlSysColorTable;
		private static bool invalid = false;
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

			//XmlDocument xmlDoc = new XmlDocument();
			//xmlDoc.Load(@"XMLFile1.xml");
			//XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/TimerJobConfig");
			//string siteurl = "", sourceurl = "", destinationurl = "";
			//foreach (XmlNode node in nodeList)
			//{
			//	siteurl = node.SelectSingleNode("siteurl").InnerText;
			//	sourceurl = node.SelectSingleNode("sourceFolder").InnerText;
			//	destinationurl = node.SelectSingleNode("destinationfolder").InnerText;
			//}
			//Console.WriteLine("SiteURL = {0}, SourceUrl= {1} , DestinationUrl = {2}", siteurl, sourceurl, destinationurl);

			//SP.ClientContext ctxSite = GetSPOContext();
			//string libraryname = "Documents";
			//var list = ctxSite.Web.Lists.GetByTitle(libraryname);
			//ctxSite.Load(list);
			//ctxSite.ExecuteQuery();
			//SP.Folder folder = list.RootFolder;
			//SP.FileCollection files = folder.Files;
			//ctxSite.Load(files);
			//ctxSite.ExecuteQuery();

			//foreach (SP.File f in files)
			//{
			//	Console.WriteLine(f.Name);

			//	SP.FileInformation fileInformation = SP.File.OpenBinaryDirect(ctxSite, (string)f.ServerRelativeUrl);
			//	using (System.IO.StreamReader sr = new System.IO.StreamReader(fileInformation.Stream))
			//	{
			//		// Read the stream to a string, and write the string to the console.
			//		String line = sr.ReadToEnd();
			//		Console.WriteLine(line);
			//	}
			//}

			#region delete temp files windows
			//string[] filePaths = Directory.GetFiles(@"C:\Users\rpshm\AppData\Local\Temp\","*.*",SearchOption.AllDirectories);
			//string path = @"C:\Users\rpshm\AppData\Local\Temp\";
			//DirectoryInfo directory = new DirectoryInfo(path);

			//Console.WriteLine("Files Count in path {0}",filePaths.Length);
			//int count = 0;
			//foreach (string filePath in filePaths)
			//{
			//	try
			//	{
			//		File.Delete(filePath);
			//		count++;
			//		Console.WriteLine("Files Deleted at File Path {0}",filePath);
			//	}
			//	catch (Exception)
			//	{

			//		continue;
			//	}

			//}

			//foreach (DirectoryInfo item in directory.GetDirectories())
			//{
			//	item.Delete();
			//}

			//Console.WriteLine("{0} Files Were Deleted from Temp Folder",count);
			//Console.ReadLine();
			#endregion temp file delete

			#region send email using outlook
			//SendMail("<h3> new mail test</h3>", "rupesh79bit@gmail.com;rupeshkumar1724@gmail.com", "test mail new One", "itsrupeshbit@gmail.com;rupeshkumar1724@gmail.com");
			#endregion send email using outlook account.
			//Thread th = new Thread(() =>
			//  {
			//	  Console.WriteLine("thred test");
			//  });
			//th.Start();
			//Task task = Task.Factory.StartNew(() =>
			//  {
			//	  Console.WriteLine("Task Test");
			//  });

			string htmlColor = "Blue";

			// Translate htmlColor to a GDI+ Color structure.
			//Color myColor = FromHtml(htmlColor);
			//var tempList = new Dictionary<int,string>();
			//try
			//{

			//	tempList.Add(1, "new1");
			//	tempList.Add(2, "new1");
			//	if (!tempList.ContainsKey(1))
			//		tempList.Add(1, "new1");
			//	tempList.Add(3, "new1");
			//}
			//catch (Exception ex)
			//{
			//	foreach (var item in tempList)
			//	{
			//		Console.WriteLine(item.Value);
			//	}
			//}

			//foreach (var item in tempList)
			//{
			//	Console.WriteLine(item.Value);
			//}
			//Console.WriteLine("ahshs2".ToLowerInvariant()); ;
			//Regex r = new Regex(@"^(?=.{7,})((?=.*[!@#$%^&*()\-_=+{};:,<.>]){1})(?=.*\w).*$");
			////class Regex Repesents an immutable regular expression.    

			//string[] str = { "evs@1234", "ertyuioplk", "evds@3456", "evs1234$", "Evs1234$" };
			////Input strings for Match valid mobile number.    

			//foreach (string s in str)
			//{
			//	try
			//	{
			//		Console.WriteLine("{0} {1} a valid password.", s,
			//		r.IsMatch(s) ? "is" : "is not");
			//		Console.WriteLine(1.00.ToString());
			//	}
			//	catch (Exception)
			//	{
			//		if (s == "evs@1234")
			//		{
			//			continue;
			//		}
					
			//	}
				
				
				
			//	//The IsMatch method is used to validate a string or     
			//	//to ensure that a string conforms to a particular pattern.    
			//}

		}

		public static Color FromHtml(string htmlColor)
		{
			Color c = Color.Empty;

			// empty color
			if ((htmlColor == null) || (htmlColor.Length == 0))
				return c;

			// #RRGGBB or #RGB
			if ((htmlColor[0] == '#') &&
				((htmlColor.Length == 7) || (htmlColor.Length == 4)))
			{

				if (htmlColor.Length == 7)
				{
					c = Color.FromArgb(Convert.ToInt32(htmlColor.Substring(1, 2), 16),
									   Convert.ToInt32(htmlColor.Substring(3, 2), 16),
									   Convert.ToInt32(htmlColor.Substring(5, 2), 16));
				}
				else
				{
					string r = Char.ToString(htmlColor[1]);
					string g = Char.ToString(htmlColor[2]);
					string b = Char.ToString(htmlColor[3]);

					c = Color.FromArgb(Convert.ToInt32(r + r, 16),
									   Convert.ToInt32(g + g, 16),
									   Convert.ToInt32(b + b, 16));
				}
			}

			// special case. Html requires LightGrey, but .NET uses LightGray
			if (c.IsEmpty && String.Equals(htmlColor, "LightGrey", StringComparison.OrdinalIgnoreCase))
			{
				c = Color.LightGray;
			}

			// System color
			if (c.IsEmpty)
			{
				if (htmlSysColorTable == null)
				{
					InitializeHtmlSysColorTable();
				}

				object o = htmlSysColorTable[htmlColor.ToLower(CultureInfo.InvariantCulture)];
				if (o != null)
				{
					c = (Color)o;
				}
			}

			// resort to type converter which will handle named colors
			if (c.IsEmpty)
			{
				c = (Color)TypeDescriptor.GetConverter(typeof(Color)).ConvertFromString(htmlColor);
			}

			return c;
		}
		private static void InitializeHtmlSysColorTable()
		{
			htmlSysColorTable = new Hashtable(26);
			htmlSysColorTable["activeborder"] = Color.FromKnownColor(KnownColor.ActiveBorder);
			htmlSysColorTable["activecaption"] = Color.FromKnownColor(KnownColor.ActiveCaption);
			htmlSysColorTable["appworkspace"] = Color.FromKnownColor(KnownColor.AppWorkspace);
			htmlSysColorTable["background"] = Color.FromKnownColor(KnownColor.Desktop);
			htmlSysColorTable["buttonface"] = Color.FromKnownColor(KnownColor.Control);
			htmlSysColorTable["buttonhighlight"] = Color.FromKnownColor(KnownColor.ControlLightLight);
			htmlSysColorTable["buttonshadow"] = Color.FromKnownColor(KnownColor.ControlDark);
			htmlSysColorTable["buttontext"] = Color.FromKnownColor(KnownColor.ControlText);
			htmlSysColorTable["captiontext"] = Color.FromKnownColor(KnownColor.ActiveCaptionText);
			htmlSysColorTable["graytext"] = Color.FromKnownColor(KnownColor.GrayText);
			htmlSysColorTable["highlight"] = Color.FromKnownColor(KnownColor.Highlight);
			htmlSysColorTable["highlighttext"] = Color.FromKnownColor(KnownColor.HighlightText);
			htmlSysColorTable["inactiveborder"] = Color.FromKnownColor(KnownColor.InactiveBorder);
			htmlSysColorTable["inactivecaption"] = Color.FromKnownColor(KnownColor.InactiveCaption);
			htmlSysColorTable["inactivecaptiontext"] = Color.FromKnownColor(KnownColor.InactiveCaptionText);
			htmlSysColorTable["infobackground"] = Color.FromKnownColor(KnownColor.Info);
			htmlSysColorTable["infotext"] = Color.FromKnownColor(KnownColor.InfoText);
			htmlSysColorTable["menu"] = Color.FromKnownColor(KnownColor.Menu);
			htmlSysColorTable["menutext"] = Color.FromKnownColor(KnownColor.MenuText);
			htmlSysColorTable["scrollbar"] = Color.FromKnownColor(KnownColor.ScrollBar);
			htmlSysColorTable["threeddarkshadow"] = Color.FromKnownColor(KnownColor.ControlDarkDark);
			htmlSysColorTable["threedface"] = Color.FromKnownColor(KnownColor.Control);
			htmlSysColorTable["threedhighlight"] = Color.FromKnownColor(KnownColor.ControlLight);
			htmlSysColorTable["threedlightshadow"] = Color.FromKnownColor(KnownColor.ControlLightLight);
			htmlSysColorTable["window"] = Color.FromKnownColor(KnownColor.Window);
			htmlSysColorTable["windowframe"] = Color.FromKnownColor(KnownColor.WindowFrame);
			htmlSysColorTable["windowtext"] = Color.FromKnownColor(KnownColor.WindowText);
		}

		private static SP.ClientContext GetSPOContext()
		{

			string UserName = "dmaestro17121993@devbit2k11.onmicrosoft.com";
			string spsiteurl = "https://devbit2k11.sharepoint.com/sites/MyCompany/";
			string Pwd = "!mp0rtant2020";
			var secure = new SecureString();
			foreach (char c in Pwd)
			{
				secure.AppendChar(c);
			}
			SP.ClientContext spoContext = new SP.ClientContext(spsiteurl);
			spoContext.Credentials = new SP.SharePointOnlineCredentials(UserName, secure);
			return spoContext;

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

		public static bool SendMail(string htmlBody,string toEmails,string subject,string ccEmails)
		{
			MsOutlook.Application outlookApp = new MsOutlook.Application();
			if (outlookApp == null)
				return false;

			// create a new mail item.
			MsOutlook.MailItem mail = (MsOutlook.MailItem)outlookApp.CreateItem(MsOutlook.OlItemType.olMailItem);
			MsOutlook.Recipients recipients = mail.Recipients as MsOutlook.Recipients;
			MsOutlook.Recipient recipientTo = null;
			MsOutlook.Recipient recipientCC = null;
			MsOutlook.Recipient recipientBCC = null;
			// set html body. 
			// add the body of the email
			mail.HTMLBody = htmlBody;
			mail.BodyFormat = MsOutlook.OlBodyFormat.olFormatHTML;
			mail.Subject = subject;
			mail.Importance = MsOutlook.OlImportance.olImportanceNormal;
			var to = toEmails.Split(';');
			foreach (string tempTO in to)
			{
				recipientTo = recipients.Add(tempTO);
				recipientTo.Type = (int)MsOutlook.OlMailRecipientType.olTo;
			}
			var cc = ccEmails.Split(';');
			foreach (string tempCC in cc)
			{
				recipientCC = recipients.Add(tempCC);
				recipientCC.Type = (int)MsOutlook.OlMailRecipientType.olCC;
			}
			recipients.ResolveAll();
			mail.Send();

			mail = null;
			outlookApp = null;
			recipients = null;
			return true;
		}
		public static void CreateTestMessage2(string server)
		{
			try
			{
				MailMessage mail = new MailMessage();
				SmtpClient SmtpServer = new SmtpClient("smtp.outlook.com");

				mail.From = new MailAddress("rupesh7t@gmail.com");
				mail.To.Add("rupesh79bit@gmail.com");
				mail.Subject = "Test Mail";
				mail.Body = "This is for testing SMTP mail from outlook";

				SmtpServer.Port = 587;
				SmtpServer.UseDefaultCredentials = false;
				SmtpServer.Credentials = new System.Net.NetworkCredential("rpshmech79@hotmail.com", "Dec2019*");
				SmtpServer.EnableSsl = true;

				SmtpServer.Send(mail);
				Console.WriteLine("mail Send");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}
		private static string DomainMapper(Match match)
		{
			// IdnMapping class with default property values.
			IdnMapping idn = new IdnMapping();

			string domainName = match.Groups[2].Value;
			try
			{
				domainName = idn.GetAscii(domainName);
			}
			catch (ArgumentException)
			{
				invalid = true;
			}
			return match.Groups[1].Value + domainName;
		}
		public static bool IsValidEmailString(string strIn)
		{
			invalid = false;
			if (String.IsNullOrEmpty(strIn))
				return false;

			// Use IdnMapping class to convert Unicode domain names. 
			try
			{
				strIn = Regex.Replace(strIn, @"(@)(.+)$", DomainMapper,
									  RegexOptions.None, TimeSpan.FromMilliseconds(200));
			}
			catch (RegexMatchTimeoutException)
			{
				return false;
			}

			if (invalid)
				return false;

			// Return true if strIn is in valid e-mail format. 
			try
			{
				return Regex.IsMatch(strIn,
					  @"^(?("")(""[^""]+?""@)|
                      (([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
					  @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,24}))$",
					  RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
			}
			catch (RegexMatchTimeoutException)
			{
				return false;
			}
		}
		public static void sendShortEmail(string body, string EmailList, string subject)
		{
			SmtpClient client = new SmtpClient("smtp.live.com");
			client.Port = 587; // or 25
			client.DeliveryMethod = SmtpDeliveryMethod.Network;
			client.UseDefaultCredentials = true;
			System.Net.NetworkCredential credentials = CredentialCache.DefaultNetworkCredentials;
			client.EnableSsl = true;
			client.Credentials = credentials;
			try
			{
				var mail = new MailMessage("rpshmech79@hotmail.com", EmailList);
				mail.Subject = subject;
				mail.Body = body;
				client.Send(mail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
	
}
