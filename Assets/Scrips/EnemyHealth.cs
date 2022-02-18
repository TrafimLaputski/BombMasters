using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    UIManager UI;
    GameManager GameManager;
    private void Start()
    {
        UI = FindObjectOfType<UIManager>();
        GameManager = FindObjectOfType<GameManager>();
    }




    public void EnemyDead()
    {
        GameManager.enemyCount = -1;
        UI.enemyCount = -1;
        Destroy(gameObject);
    }
}
