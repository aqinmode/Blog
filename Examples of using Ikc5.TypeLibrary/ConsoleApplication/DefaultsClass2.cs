﻿using System.ComponentModel;
using Ikc5.TypeLibrary;

namespace ConsoleApplication
{
	internal class DefaultsClass2
	{
		public DefaultsClass2()
		{
			// set value of Name property to default value "Instance2"
			this.GetDefaultValue(ref _name, nameof(Name));
			// set value of Index property to default value, 2
			this.GetDefaultValue(ref _index, 5, nameof(Index));
			// set value of Checked property to TRUE despite DefaultValue attribute is not used
			this.GetDefaultValue(ref _checked, true, nameof(Checked));
		}

		private string _name;

		[DefaultValue("Instance2")]
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private int _index;

		[DefaultValue(2)]
		public int Index
		{
			get { return _index; }
			set { _index = value; }
		}

		private bool _checked;

		public bool Checked
		{
			get { return _checked; }
			set { _checked = value; }
		}

		public override string ToString()
		{
			return $"Index {Index}, Name \"{Name}\", Checked " + (Checked ? "On" : "Off");
		}
	}
}
