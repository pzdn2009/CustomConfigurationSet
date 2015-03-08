using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Examples
{
	public class DatabasesElementCollection: ConfigurationElementCollection
	{
		#region Constructor
		public DatabasesElementCollection()
		{
		}
		#endregion

		#region Properties
		public override ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return ConfigurationElementCollectionType.BasicMap;
			}
		}
		protected override string ElementName
		{
			get
			{
				return "database";
			}
		}

		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return new ConfigurationPropertyCollection();
			}
		}
		#endregion

		#region Indexers
		public DatabaseElement this[int index]
		{
			get
			{
				return (DatabaseElement)base.BaseGet(index);
			}
			set
			{
				if (base.BaseGet(index) != null)
				{
					base.BaseRemoveAt(index);
				}
				base.BaseAdd(index, value);
			}
		}

		public new DatabaseElement this[string name]
		{
			get
			{
				return (DatabaseElement)base.BaseGet(name);
			}
		}
		#endregion

		#region Methods
		public void Add(DatabaseElement item)
		{
			base.BaseAdd(item);
		}

		public void Remove(DatabaseElement item)
		{
			base.BaseRemove(item);
		}

		public void RemoveAt(int index)
		{
			base.BaseRemoveAt(index);
		}
		#endregion

		#region Overrides
		protected override ConfigurationElement CreateNewElement()
		{
			return new DatabaseElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return (element as DatabaseElement).NameType;
		}
		#endregion
	}
}
