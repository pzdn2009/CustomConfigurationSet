using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Examples
{
	public class DatabasesSection: ConfigurationSection
	{
		#region Constructors
		static DatabasesSection()
		{
			_propSectionName = new ConfigurationProperty(
				"name",
				typeof(string),
				null,
				ConfigurationPropertyOptions.IsRequired
				);

			_propDatabases = new ConfigurationProperty(
				"",
				typeof(DatabasesElementCollection),
				null,
				ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsDefaultCollection
				);

			_properties = new ConfigurationPropertyCollection();

			_properties.Add(_propSectionName);
			_properties.Add(_propDatabases);
		}
		#endregion

		#region Fields
		private static ConfigurationPropertyCollection _properties;
		private static ConfigurationProperty _propSectionName;
		private static ConfigurationProperty _propDatabases;
		#endregion

		#region Properties
		public string Name
		{
			get { return (string)base[_propSectionName]; }
			set { base[_propSectionName] = value; }
		}

		public DatabasesElementCollection AllDatabases
		{
			get { return (DatabasesElementCollection)base[_propDatabases]; }
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