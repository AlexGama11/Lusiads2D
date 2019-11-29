using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
public int score;
public Text scoreDisplay;
public Text scoreDisplayOver;

private void Update()
{
    scoreDisplay.text = score.ToString();
	scoreDisplayOver.text = score.ToString();
}
  
 private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        Destroy(other.gameObject);
    }
  
}  
 
