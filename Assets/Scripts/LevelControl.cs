// Libraries unity is going to use
using UnityEngine;
using UnityEngine.SceneManagement;
// Name of the object
public class LevelControl : MonoBehaviour
{
	// a variable which allows us to specify which scene we want to load.
	
	public string LevelOne;
	public string MainMenu;
	
	public void BackToMain()
	{
	    // This line will trigger scene manager to load the main menu.
		        SceneManager.LoadScene(MainMenu);
	}
	// This line will make the player exit the application.
	
	public void QuitGame()
	{
	 	Application.Quit();
	}
}
	