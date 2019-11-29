// Libraries unity is going to use
using UnityEngine;
using UnityEngine.SceneManagement;
// Name of the object
public class MenuCTRL : MonoBehaviour
{
	// a variable which allows us to specify which scene we want to load.
	
	public string LevelOne;
	public string MainMenu;
	
	public GameObject StartPanel;
	public GameObject CreditsPanel;
	public GameObject ControlsPanel;
	
    // Start is called before the first frame update
    void Start()
    {
	// The line that follows will set the Start and Credits panels to be invisible
        StartPanel.SetActive(true);
		CreditsPanel.SetActive(false);
		ControlsPanel.SetActive(false);
    }

// This function will be attached to a button
    public void Play()
	{
		// This line will trigger scene manager to load the first level.
		        SceneManager.LoadScene(LevelOne);
				Time.timeScale = 1;
	}
	
	public void BackToMain()
	{
	    // This line will trigger scene manager to load the main menu.
		        SceneManager.LoadScene(MainMenu);
	}
	
	public void CreditsPanelShow()
	{
	    // This line will trigger scene manager to show the Credits panel.
		        CreditsPanel.SetActive(true);
    }
	
	public void CreditsPanelHide()
	{
	    // This line will trigger scene manager to hide the Credits panel again.
		        CreditsPanel.SetActive(false);
    }
	
	public void ControlsPanelShow()
	{
	    // This line will trigger scene manager to show the Controls panel.
		        ControlsPanel.SetActive(true);
    }
	
	public void ControlsPanelHide()
	{
	    // This line will trigger scene manager to hide the Controls panel again.
		        ControlsPanel.SetActive(false);
    }
	
	public void QuitGame()
	{
	 	Application.Quit();
	}
}
	