using UnityEngine;

public class MoedasJogador : MonoBehaviour
{

    private int coins;
   
    private void OnEnable()
    {
        JogadorOM.CollectedCoin += Collectcoins;
    }
    
    private void OnDisable()
    {
        JogadorOM.CollectedCoin -= Collectcoins;
    }
    
    public void Collectcoins()
    {
        Debug.Log("Peguei uma moeda");
           
        coins += 1;
        JogadorOM.CoinsAreChanged(coins);
    }
}