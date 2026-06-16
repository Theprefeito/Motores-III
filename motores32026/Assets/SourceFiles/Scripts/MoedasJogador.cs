using UnityEngine;

public class MoedasJogador : MonoBehaviour
{

    private int coins;
    
    public void Collectcoins()
    {
        Debug.Log("Peguei uma moeda");
           
        coins += 1;
        JogadorOM.CoinsAreChanged(coins);
    }
}