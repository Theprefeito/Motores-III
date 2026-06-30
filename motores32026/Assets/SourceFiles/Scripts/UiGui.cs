using TMPro;
using UnityEngine;

public class UiGUI : MonoBehaviour
{
     
    [SerializeField] TextMeshProUGUI coins;
    

    private void OnEnable()
    {
        JogadorOM.ChangeCoins += UpdateCoinsText;
    }
    
    private void OnDisable()
    {
        JogadorOM.ChangeCoins += UpdateCoinsText;
    }


    private void UpdateCoinsText(int quantidade)
    {
        coins.text = quantidade.ToString();
    }
}