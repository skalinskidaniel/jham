using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayBotao : MonoBehaviour
{
   [SerializeField] private string jogo = "SampleScene";
   [SerializeField] private string Nois = "NoisOpcao";
   [SerializeField] private string Menu = "Menu";
    public void Playgames()
    {
        SceneManager.LoadScene("fase_01");
    }
    public void Galerinhass()
    {
        SceneManager.LoadScene("NoisOpcao");
    }
    public void VOlta()
    {
        SceneManager.LoadScene("menu");
    }
}
