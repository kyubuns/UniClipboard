// ClipboardHelper(PC/Mac)
// http://answers.unity3d.com/questions/266244/how-can-i-add-copypaste-clipboard-support-to-my-ga.html

using UnityEngine;
using System;
using System.Reflection;

namespace UniClipboardHelper
{

public class PC
{
	public static string clipBoard
	{
		get
		{
			return GUIUtility.systemCopyBuffer;
		}
		set
		{
			GUIUtility.systemCopyBuffer = value;
		}
	}
}

}
