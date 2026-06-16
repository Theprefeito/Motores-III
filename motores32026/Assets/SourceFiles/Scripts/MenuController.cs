using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    public void CarregarCena()
    {
      
        GameManager.Instance.CarregarCena("GetStarted_Scene", "UI");
    }
    
    public void SairDoJogo()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}
