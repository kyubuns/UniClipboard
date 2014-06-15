using UnityEngine;
using System.Collections;

public class Sample : MonoBehaviour {
	string clipboardValue;

	void OnGUI()
	{
		GUI.Box(new Rect(10,10,320,280), "UniClipboard Test");

		if(GUI.Button(new Rect(20,40,300,60), "Copy"))
		{
			UniClipboard.value = "Hello, UniClipboard!";
		}

		if(GUI.Button(new Rect(20,120,300,60), "Paste"))
		{
			clipboardValue = UniClipboard.value;
		}

		GUI.Label(new Rect(20,200,400,100), clipboardValue);
	}
}
