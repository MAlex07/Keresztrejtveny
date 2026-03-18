using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keresztrejtveny
{
	internal class KeresztrejtvenyRacs
	{
		private List<string> Adatsorok;
		private char[,] Racs;
		private int[,] Sorszamok;

		public KeresztrejtvenyRacs(string forras)
		{
			this.Adatsorok = new List<string>();
			BeolvasAdatsorok(forras);
			Racs = new char[SorokSzama, OszlopokSzama];
			FeltoltRacs();
		}

		public char[,] Racs1 { get => Racs; set => Racs = value; }
		public int[,] Sorszamok1 { get => Sorszamok; set => Sorszamok = value; }

		public int SorokSzama { get => Adatsorok.Count; }
		public int OszlopokSzama { get => Adatsorok[0].Length; }


		private void BeolvasAdatsorok(string forras)
		{
			foreach (var sor in File.ReadAllLines(forras))
			{
				this.Adatsorok.Add(sor);
			}
		}

		private void FeltoltRacs()
		{
			for(int sorindex = 0; sorindex<SorokSzama; sorindex++)
			{
				for(int oszlopindex = 0; oszlopindex<OszlopokSzama; oszlopindex++)
				{
					Racs[sorindex, oszlopindex] = Adatsorok[sorindex][oszlopindex];
				}
			}
		}

		public void KiirRacs()
		{
			for(int sorindex = 0; sorindex<SorokSzama; sorindex++)
			{
				for(int oszlopindex = 0; oszlopindex<OszlopokSzama; oszlopindex++)
				{
					Console.Write(Racs[sorindex, oszlopindex]);
				}
				Console.WriteLine();
			}

		}


	}
}
