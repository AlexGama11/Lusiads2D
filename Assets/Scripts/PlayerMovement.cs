using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{

    public Vector2 playerPos;
    public float moveYaxis;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int Health = 3;
    private float targetTime = 0.0f;
    public Animator camAnim;
	public Text healthDisplay;
	public GameObject effect;
	public GameObject GameOver;
	public GameObject spawner;
	private GameObject Enemy;
   
   private void Start()
   {
     Enemy = GameObject.FindWithTag("Obstacle");
   }
   private void Update()
   {
   
   targetTime += Time.deltaTime;
        
       if (Health <= 0)

	   {
	   
	   		Time.timeScale = 0;
	       spawner.SetActive(false);
		   GameOver.SetActive(true);
		   Destroy(gameObject);
		   Destroy(Enemy);
	   }
	   
	   healthDisplay.text = Health.ToString();
		  
    transform.position = Vector2.MoveTowards(transform.position, playerPos,speed*Time.deltaTime);
	
  if (targetTime >= 1.0f)
   {
 
 if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
            {
                camAnim.SetTrigger("shake");
                Instantiate(effect, transform.position, Quaternion.identity);
                playerPos = new Vector2(transform.position.x, transform.position.y + moveYaxis);
            }
   
   else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
            {
                camAnim.SetTrigger("shake");
                Instantiate(effect, transform.position, Quaternion.identity);
                playerPos = new Vector2(transform.position.x, transform.position.y - moveYaxis);
            }
   
}
   
}
}