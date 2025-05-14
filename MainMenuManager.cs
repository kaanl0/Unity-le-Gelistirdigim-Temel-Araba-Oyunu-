using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject infoText;

    public void StartGame()
    {
        SceneManager.LoadScene(1); // 1 numaralý sahne (Game Scene) yüklenir
    }

    public void ShowInfo()
    {
        infoText.SetActive(!infoText.activeSelf); // Aç/kapa yapar
    }
}
