using UnityEngine;

public class Moeda : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            MoedasJogador Player = collision.GetComponent<MoedasJogador>();
            Player.Collectcoins();
            Destroy(gameObject);
        }
    }
}