using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_5._Border_Control
{
	public class Robot : ICitizen
	{
		public string Id { get; set; }
		private string model;

		public Robot(string id, string model)
		{
			this.Id = id;
			this.Model = model;
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
	}
}
