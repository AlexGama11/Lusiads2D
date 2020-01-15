using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
	public float speed;
    public GameObject effect;
	
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
	}
	
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().health--;
			other.GetComponent<PlayerMovement>().camAnim.SetTrigger("shake");
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
