using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainUI : MonoBehaviour {

	public Button yesExitButton;
	public Button musicToggleButton;
	public bool musicOff = true;

	// Use this for initialization
	void Start ()
	{
		Button exitButton = yesExitButton.GetComponent<Button>();
		exitButton.onClick.AddListener(doExit);

		Button musicButton = musicToggleButton.GetComponent<Button> ();
		musicButton.onClick.AddListener (toggleMusic);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void doExit()
	{
		Application.Quit ();	
	}

	public void toggleMusic() {
		if (musicOff == true) {
			AudioListener.volume = 0.0F;
			musicOff = false;
		} else {
			AudioListener.volume = 0.7F;
			musicOff = true;
		}
	}
}
