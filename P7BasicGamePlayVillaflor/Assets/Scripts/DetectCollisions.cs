using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Animal"))
        {
            gameManager.AddLives(-1); 
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Projectile"))
        {
            gameManager.AddScore(5);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
}
}
