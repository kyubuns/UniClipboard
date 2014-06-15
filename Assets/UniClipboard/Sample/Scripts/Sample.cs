using UnityEngine;
using System.Collections;

public class Sample : MonoBehaviour {
	string clipboardValue;

	void OnGUI()
	{
		GUI.Box(new Rect(10,10,200,140), "UniClipboard Test");

		if(GUI.Button(new Rect(20,40,150,20), "Copy"))
		{
			UniClipboard.value = "Hello, UniClipboard!";
		}

		if(GUI.Button(new Rect(20,70,150,20), "Paste"))
		{
			clipboardValue = UniClipboard.value;
		}

		GUI.Label(new Rect(30,90,200,80), clipboardValue);
	}
}
