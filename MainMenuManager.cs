using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject infoText;

    public void StartGame()
    {
        SceneManager.LoadScene(1); // 1 numaral� sahne (Game Scene) y�klenir
    }

    public void ShowInfo()
    {
        infoText.SetActive(!infoText.activeSelf); // A�/kapa yapar
    }
}
