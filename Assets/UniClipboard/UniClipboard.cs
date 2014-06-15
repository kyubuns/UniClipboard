using UnityEngine;
using System.Collections;

public static class UniClipboard
{
	public static string value
	{
		get
		{
			return UniClipboardHelper.PC.clipBoard;
		}

		set
		{
			UniClipboardHelper.PC.clipBoard = value;
		}
	}
}
