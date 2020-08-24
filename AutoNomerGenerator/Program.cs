using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AutoNomerGenerator
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			string[] codearray = new string[28];
			codearray[0] = "AA";
			codearray[1] = "AI";
			codearray[2] = "AB";
			codearray[3] = "AC";
			codearray[4] = "AE";
			codearray[5] = "AK";
			codearray[6] = "AM";
			codearray[7] = "AH";
			codearray[8] = "AO";
			codearray[9] = "AP";
			codearray[10] = "AT";
			codearray[11] = "AX";
			codearray[12] = "BA";
			codearray[13] = "BB";
			codearray[14] = "BE";
			codearray[15] = "BK";
			codearray[16] = "BM";
			codearray[17] = "BH";
			codearray[18] = "BO";
			codearray[19] = "BC";
			codearray[20] = "BT";
			codearray[21] = "BX";
			codearray[22] = "BI";
			codearray[23] = "CA";
			codearray[24] = "CB";
			codearray[25] = "CE";
			codearray[26] = "CH";
			codearray[27] = "II";
			
			string series = "QWERTYUIOPASDFGHJKLZXCVBNM";

			Random rand = new Random();

			string number = "";

			string date;
			int mounth;
			int day;


			//for (int i = 0; i < 500; i++) //license
			//{
			//	number = codearray[rand.Next(0, 27)];
			//	for (int j = 0; j < 4; j++)
			//	{
			//		number = number + rand.Next(0, 10).ToString();
			//	}
			//	number = number + series[rand.Next(0, series.Length)];
			//	number = number + series[rand.Next(0, series.Length)];
			//	Console.WriteLine(number);
			//	System.Windows.Forms.Clipboard.SetText(number);
			//	//Console.ReadKey();
			//	Thread.Sleep(300);
			//	Console.Clear();
			//}

			//int mileage;
			//for (int i = 0; i < 1000; i++) //numbers
			//{
			//	mileage = rand.Next(10, 100000);
			//	Console.WriteLine(mileage);
			//	Clipboard.SetText(mileage.ToString());
			//	Thread.Sleep(200);
			//	Console.Clear();
			//}

			
			for (int i = 0; i < 1000; i++) //date
			{
				date = rand.Next(2008, 2020).ToString();
				date += "-";
				mounth = rand.Next(1, 13);
				if (mounth < 10)
					date += "0";
				date += mounth.ToString();
				date += "-";
				day = rand.Next(1, 28);
				if (day < 10)
					date += "0";
				date += day.ToString();
				Console.WriteLine(date);
				Clipboard.SetText(date);
				Thread.Sleep(300);
				Console.Clear();
			}


			Console.ReadKey();
		}
	}
}
