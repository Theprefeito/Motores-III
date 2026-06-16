using UnityEngine;

public class Moeda : MonoBehaviour
{
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