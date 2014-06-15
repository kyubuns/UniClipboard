using UnityEngine;
using System.Collections;

public static class UniClipboard
{
	public static string value
	{
		set
		{
#if UNITY_IOS && !UNITY_EDITOR
			UniClipboardHelper.iOS.SetClipboard(value);
#else
			UniClipboardHelper.PC.clipBoard = value;
#endif
		}

		get
		{
#if UNITY_IOS && !UNITY_EDITOR
			return UniClipboardHelper.iOS.GetClipboard();
#else
			return UniClipboardHelper.PC.clipBoard;
#endif
		}
	}
}
