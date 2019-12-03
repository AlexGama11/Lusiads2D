using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
public int score;
public Text scoreDisplay;
public Text scoreDisplayOver;
public string LevelOne;
public GameObject NextLevel;

private void Update()
{
    scoreDisplay.text = score.ToString();
	scoreDisplayOver.text = score.ToString();
	if (score >= 100)

	   {
	   NextLevel.SetActive(true);
	   Time.timeScale = 0;
	   }
}
  
 private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        Destroy(other.gameObject);
    }
	
}  
 
