using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] Text EnemyCountText;
    [SerializeField] GameManager GameManager;
    [SerializeField] PlayerHP Player;

    [SerializeField] GameObject WinMenuUI;
    [SerializeField] GameObject LoseMenuUI;
    [SerializeField] GameObject GameMenuUI;
    [SerializeField] GameObject MainMenuUI;



    int EnemyCount = 0;

    void Start()
    {
        GameManager.PlayerWin += Win;

        Player.PlayerLose += Lose;

        GameManager.GoToMenu += GoToMenu;

        GameManager.StartGame += GameMenu;
    }

    public int enemyCount
    {
        get
        {
            return 0;
        }

        set
        {
            EnemyCount += value;
            EnemyCountText.text = ("X" + EnemyCount);
        }

    }

    private void Win()
    {
        GameMenuUI.SetActive(false);
        WinMenuUI.SetActive(true);

    }

    private void Lose()
    {

        GameMenuUI.SetActive(false);
        LoseMenuUI.SetActive(true);
    }

    private void GoToMenu()
    {

        WinMenuUI.SetActive(false);
        LoseMenuUI.SetActive(false);
        MainMenuUI.SetActive(true);
    }

    void GameMenu()
    {

       MainMenuUI.SetActive(false);
       GameMenuUI.SetActive(true);
    }
}
