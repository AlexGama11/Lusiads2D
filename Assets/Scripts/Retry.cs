using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
		{
		    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			Time.timeScale = 1;
		}
    }
}
