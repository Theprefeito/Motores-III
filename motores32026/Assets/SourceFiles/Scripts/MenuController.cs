using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    public void CarregarCena(string nomeDaCena)
    {
      
        GameManager.Instance.CarregarCena(nomeDaCena);
    }
    
    public void SairDoJogo()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}
