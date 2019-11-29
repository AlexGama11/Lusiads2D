// Libraries unity is going to use
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Name of the object
public class CreditsCTRL : MonoBehaviour
{
	// a variable which allows us to specify which scene we want to load.
	
	public string Credits;
	public string MainMenu;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

// This function will be attached to a button

    public void PlayCredits()
	{
		// This line will trigger scene manager to change scenes to one specified in the variable
		        SceneManager.LoadScene(Credits);
	}
	
	public void BackToMain()
	{
	    // This line will trigger scene manager to go back to the scene specified in the variable
		        SceneManager.LoadScene(MainMenu);
	}
	
}
