using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
	class Program
    {
		public int Id { get; set; }
		static void Main(string[] args)
        {
			//Science s = new Science();
			//Console.WriteLine(s.Add(2, 6)); 

			Base based = new Base();
			Derived derived = new Derived();
			Base baseTypeandDerivedobject = new Derived();
			//	Derived derivedTypeandBaseOject = (Derived)(b);//compiler error not possible

			Console.WriteLine(derived.methodToHideWithVirtual()	);
			Console.ReadLine();

			var dbMigrator = new DbMigrator(new Logger());
			var installer = new Installer(new Logger());

			installer.Install();
			dbMigrator.Migrate();
			
        }
    }
	 
	public interface ITaxCalculator
	{
		 int Add(int x, int y);
	}

	public class Science:Math,ITaxCalculator
	{
		public string FirstName { get; set; }
		public DateTime Dob { get; set; }

		 public int Add(int x, int y)
		{
			return x + y;
		}

		 
	}

	public class Base
	{
		public virtual string methodOverride()
		{
			return "parent method to overide";
		}
		public string method()
		{
			return "parent simple method";
		}
		public string methodToHide()
		{
			return "parent method to hide";
		}
		public virtual string methodToHideWithVirtual()
		{
			return "parent method to hide With Virtual";
		}
	}
	public class Derived : Base
	{
		public override string methodOverride()
		{
			return "child method overidded";
		}
		public string method()
		{
			return "child simple method";
		}
		public new string methodToHide()
		{
			return "child method hidden";
		}
		public new string methodToHideWithVirtual()
		{
			return "child method to hide With Virtual";
		}
	}
}
