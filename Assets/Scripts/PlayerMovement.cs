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
    public int health = 3;
    private float targetTime = 0.0f;
	public GameObject effect;
	public GameObject GameOver;
	public GameObject spawner;
	private GameObject Enemy;
	public Animator camAnim;
	public int numOfhearts;
	
	public Image[] hearts;
	public Sprite fullheart;
	public Sprite emptyheart;
   
   private void Start()
   {
     Enemy = GameObject.FindWithTag("Obstacle");
   }
   private void Update()
   {
   
   targetTime += Time.deltaTime;
    if (health > numOfhearts)
		{
		health = numOfhearts;
		}
		
	    for (int i = 0; i < hearts.Length; i++)
		{
		
		 if (i < health)
		 {
		 hearts[i].sprite = fullheart;
		 }
		 else
		 {
		 hearts[i].sprite = emptyheart;
		 }
		 if (i < numOfhearts)
		 {
		  hearts[i].enabled = true;
		 }
		 else 
		 {
		 hearts[i].enabled = false;
		 }
        
       if (health <= 0)

	   {
	   
	   		Time.timeScale = 0;
	       spawner.SetActive(false);
		   GameOver.SetActive(true);
		   Destroy(gameObject);
		   Destroy(Enemy);
	   }
		  
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
}