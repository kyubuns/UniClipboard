UniClipboard

text only.

support PC/Mac/iOS
don't support Android/Webplayer

* how to use

if(GUI.Button(new Rect(20,40,300,60), "Copy"))
{
	UniClipboard.value = "Hello, UniClipboard!";
}

if(GUI.Button(new Rect(20,120,300,60), "Paste"))
{
	clipboardValue = UniClipboard.value;
}
