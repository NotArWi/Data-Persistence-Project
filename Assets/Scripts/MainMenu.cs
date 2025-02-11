using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_InputField nameInput; 

       public void StartGame()
    {
        string playerName = nameInput.text.Trim();
        if (string.IsNullOrEmpty(playerName)) return; 

        PlayerPrefs.SetString("PlayerName", playerName); 
        SceneManager.LoadScene("main");
    }

    public void ResetBestScore()
    {
        PlayerPrefs.DeleteKey("BestScore");
        PlayerPrefs.DeleteKey("BestPlayer");
        PlayerPrefs.Save();

       
    }
}
