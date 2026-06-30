using UnityEngine;

public class Moeda : MonoBehaviour
{
    private Transform coinTransform;
    
    public void Start()
    {
        coinTransform = GetComponent<Transform>();
    }
    
    public void Update()
    {
        coinTransform.rotation = Quaternion.Euler(coinTransform.rotation.eulerAngles.x, coinTransform.rotation.eulerAngles.y + 0.6f, 0);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            JogadorOM.CoinAreCollected();
            Destroy(gameObject);
        }
    }
}