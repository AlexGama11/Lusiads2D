using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextlevelLoad : MonoBehaviour
{
    public string LevelTwo;

      public void LoadLevelTwo()
	{
		// This line will trigger scene manager to load the Second level.
		        SceneManager.LoadScene(LevelTwo);
				Time.timeScale = 1;
}
      public void Continue()
		{
		    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			Time.timeScale = 1;
		}
}
