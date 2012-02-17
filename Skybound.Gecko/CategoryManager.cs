﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Collections;

namespace Gecko
{
	public sealed class CategoryManager
	{
		private nsICategoryManager _categoryManager;

		public CategoryManager()
		{
			var categoryManager = Xpcom.GetService<nsICategoryManager>( Contracts.CategoryManager );
			_categoryManager = Xpcom.QueryInterface<nsICategoryManager>(categoryManager);
		}

		public string AddCategoryEntry(string aCategory, string aEntry, string aValue, bool aPersist, bool aReplace)
		{
			// check if it exists to prevent crash
			string value = null;
			try
			{
				value = _categoryManager.GetCategoryEntry(aCategory, aEntry);
			}
			catch ( Exception )
			{
			}
			
			if (value != null)
			{
				_categoryManager.DeleteCategoryEntry(aCategory, aEntry, aPersist);
			}

			return _categoryManager.AddCategoryEntry(aCategory, aEntry, aValue, aPersist, aReplace);
		}

		public void DeleteCategory(string aCategory)
		{
			_categoryManager.DeleteCategory(aCategory);	
		}

		public void DeleteCategoryEntry(string aCategory, string aEntry,bool aPersist) 
		{
			_categoryManager.DeleteCategoryEntry(aCategory, aEntry, aPersist);
		}

		public string GetCategoryEntry(string aCategory, string aEntry)
		{
			return _categoryManager.GetCategoryEntry( aCategory, aEntry );
		}

		public IEnumerable<string> Categories
		{
			get
			{
				return new GeckoEnumerableCollection<string, nsISupportsCString>( () => _categoryManager.EnumerateCategories(),
				                                                                  nsSupportsPrimitiveConverter.GetString );
			}
		}

		public IEnumerable<string> this[string category]
		{
			get
			{
				return
					new GeckoEnumerableCollection<string, nsISupportsCString>( () => _categoryManager.EnumerateCategory( category ),
					                                                           nsSupportsPrimitiveConverter.GetString );
			}
		}

		#region Categories List - TODO
		public static string ContentPolicy = "content-policy";
		#endregion
		
	}
}