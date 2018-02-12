using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using JetBrains.Util.Reflection;

namespace _2017
{
	public class Day7
	{
		private readonly List<ProgramInfo> _programs = new List<ProgramInfo>();

		public void AddProgram(string programInfo)
		{
			_programs.Add(new ProgramInfo(programInfo));
		}

		public string CalculateBottomProgram()
		{
			var flatten = _programs.SelectMany(x => x.SubPrograms).Union(_programs).ToArray();
			return flatten.Single(x => flatten.Count(y => y.Name == x.Name) == 1).Name;
		}


		private class ProgramInfo
		{
			public string Name;
			public List<ProgramInfo> SubPrograms;

			public ProgramInfo(string input)
			{
				var parts = input.Replace(",", "").Split(' ');
				Name = parts.First();

				if (parts.Length != 1)
					SubPrograms = parts
						.Skip(3)
						.Select(x => new ProgramInfo(x))
						.ToList();
			}
		}
	}
}