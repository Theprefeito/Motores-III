using TMPro;
using UnityEngine;

public class UiGUI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    [SerializeField] TextMeshProUGUI Moedas;
    
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
        Moedas.text = quantidade.ToString();
    }
}