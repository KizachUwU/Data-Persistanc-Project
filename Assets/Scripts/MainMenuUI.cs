using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public TMP_InputField editPlayerName;
    public Button validateButton;
    public Button startButton;
    public TextMeshProUGUI playerNameUI;

   // public string playerName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerNameInput()
    {
        SaveManager.instance.PlayerName = editPlayerName.text;
        playerNameUI.text = "Player Name : " + SaveManager.instance.PlayerName;
        
        
    }

    public void LaunchGame()
    {
        SceneManager.LoadScene(1);
    }
}
