using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchableModListForm
{
	static class Program
	{
		/// <summary>
		/// The main entry point for example application.
		/// </summary>
		[STAThread]
		static void Main ()
		{
			List<Mod> modList = new List<Mod> ();
			for (int i = 0; i < 15; i++)
			{
				Mod m = new Mod ();
				m.modID = i;
				m.modVersion = i - 0.5f;
				m.modName = i + " mod";
				m.modAuthor += ("Author " + i);
				modList.Add (m);
			}
			Application.EnableVisualStyles ();
			Application.SetCompatibleTextRenderingDefault (false);
			SearchableModListForm form = new SearchableModListForm (modList);
			Application.Run (form);
		}
	}
}
