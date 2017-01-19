using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
	private bool pressedQuitButton;
    public Button QuitButton;

	// Use this for initialization
	void Start ()
	{
		pressedQuitButton = false;
	    Button quitButton = QuitButton.GetComponent<Button>();
	    quitButton.onClick.AddListener(OnGUI);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnGUI()
	{
		if (pressedQuitButton) {
			GUI.Box (new Rect (0, 0, 200, 100), "Quittez l'application?");

			if (GUI.Button (new Rect (20, 50, 70, 30), "Oui")) {
				Application.Quit ();

			}

			if (GUI.Button (new Rect (110, 50, 70, 30), "Non")) {

				pressedQuitButton = false;
			}
		}
	}
}
