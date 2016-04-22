using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchableModListForm
{
	public class Mod : IComparable
	{
		public float modVersion
		{
			get;
			set;
		}
		public int modID
		{
			get;
			set;
		}
		public int modDownloadCount {
			get;
			set;
		}
	public string modName
		{
			get;
			set;
		}
		public string modAuthor
		{
			get;
			set;
		}
		public string modDescription
		{
			get;
			set;
		}
		public string modDownloadURL
		{
			get;
			set;
		}
		public string modImageURL
		{
			get;
			set;
		}
		public string modPageURL
		{
			get;
			set;
		}
		public string modCategory
		{
			get;
			set;
		}
		public Mod ()
		{
		}
		override
			public string ToString ()
		{
			return modName + " by " + modAuthor;
		}

		public int CompareTo (object obj)
		{
			if (obj != null)
			{
				Mod compareMod = (Mod)obj;
				return this.modName.CompareTo (compareMod.modName);
			}
			return -1;
		}
	}
}
