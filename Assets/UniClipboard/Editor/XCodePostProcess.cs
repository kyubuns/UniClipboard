using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace UniClipboard
{
	using Debug = UnityEngine.Debug;

	public static class PostProcess
	{
		[PostProcessBuild]
		public static void OnPostProcessBuild(BuildTarget target, string path)
		{
			var project = new UnityEditor.XCodeEditor.XCProject(path);

			// find current path
			string[] files = Directory.GetFiles(Application.dataPath, "UniClipboard.cs", SearchOption.AllDirectories);

			// apply projmods
			var projmodsPath = Path.Combine(Path.GetDirectoryName(files[0]), "Editor/uniclipboard.projmods");
			project.ApplyMod(projmodsPath);

			// add compile flag
			List<string> targetGuids = new List<string>();
			targetGuids.Add(project.GetFile("uniclipboard.mm").guid);

			foreach(var file in project.buildFiles)
			{
				if(!targetGuids.Contains((string)file.Value.data["fileRef"])) continue;
				file.Value.AddCompilerFlag("-fobjc-arc");
			}

			project.Save();
		}
	}
}
