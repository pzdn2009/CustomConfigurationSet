using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Examples
{

	public class DatabaseElement: ConfigurationElement
	{
		#region Constructors
		static DatabaseElement()
		{
			_proName = new ConfigurationProperty(
				"name",
				typeof(string),
				null,
				ConfigurationPropertyOptions.IsRequired
				);

			_proConnString = new ConfigurationProperty(
                "connString",
				typeof(string),
				null,
				ConfigurationPropertyOptions.None
				);

			_proFileNumber = new ConfigurationProperty(
                "fileNumber",
				typeof(int),
				0,
				ConfigurationPropertyOptions.IsRequired
				);

			_properties = new ConfigurationPropertyCollection();

			_properties.Add(_proName);
			_properties.Add(_proConnString);
			_properties.Add(_proFileNumber);
		}
		#endregion

		#region Fields
		private static ConfigurationPropertyCollection _properties;
		private static ConfigurationProperty _proName;
		private static ConfigurationProperty _proConnString;
		private static ConfigurationProperty _proFileNumber;
		#endregion

		#region Properties
		public string NameType
		{
			get { return (string)base[_proName]; }
			set { base[_proName] = value; }
		}

		public string ConnString
		{
			get { return (string)base[_proConnString]; }
			set { base[_proConnString] = value; }
		}

		public int FileNumber
		{
			get { return (int)base[_proFileNumber]; }
			set { base[_proFileNumber] = value; }
		}

		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return _properties;
			}
		}
		#endregion
	}
}
