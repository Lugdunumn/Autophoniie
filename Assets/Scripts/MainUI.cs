using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainUI : MonoBehaviour {

	public Button yesExitButton;

	// Use this for initialization
	void Start ()
	{
		Button exitButton = yesExitButton.GetComponent<Button>();
		exitButton.onClick.AddListener(doExit);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void doExit()
	{
		Application.Quit ();	
	}
}
