using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerHP player;
    Vector3 StartPlayerPosition;
    public System.Action PlayerWin;
    public System.Action GoToMenu;
    public System.Action StartGame;
  
    int EnemyCount = 0;
    void Start()
    {
        player.PlayerLose += Lose;
        StartPlayerPosition = player.transform.position;
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
     
            if (EnemyCount == 0)
            {

                Win();
            }
            
        }

    }

    private void Win()
    {
        PlayerWin?.Invoke();

        player.transform.position = StartPlayerPosition;
        player.gameObject.SetActive(false);

    }

    private void Lose()
    {
        player.transform.position = StartPlayerPosition;
        player.gameObject.SetActive(false);
    }


    public void Menu()
    {
        GoToMenu?.Invoke();

    }

    public void Game()
    {
        player.gameObject.SetActive(true);
        StartGame?.Invoke();
    }
}
