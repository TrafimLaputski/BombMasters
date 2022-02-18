using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    [SerializeField] GameObject Container;

    [SerializeField] GameObject StonePrefab;
    [SerializeField] GameObject BoxPrefab;
    [SerializeField] GameObject EnemyPrefab;
    [SerializeField] Vector2Int FieldSize;
    [SerializeField] int MaxCountOfEnemy = 3;
    [SerializeField] UIManager UI;
    [SerializeField] GameManager GameManager;

    private void Start()
    {
        GameManager.StartGame += Instantiate;
        GameManager.GoToMenu += Cleaner;

        
    }

    void Instantiate()
    {
        for (int i = FieldSize.x; i > 0; i--)
        {
            for (int a = 0; a < FieldSize.y; a++)
            {
                if ((a % 2 != 0) && (i % 2 != 0))
                {
                    Instantiate(StonePrefab, new Vector2(i, a), Quaternion.identity, Container.transform);

                }
                else
                {
                    int ChangeOfSpawn = Random.Range(0, 20);
                    if (ChangeOfSpawn < 5)
                    {
                        Instantiate(BoxPrefab, new Vector2(i, a), Quaternion.identity, Container.transform);

                    }
                    else if (ChangeOfSpawn == 17)
                    {

                        if (MaxCountOfEnemy > 0)
                        {
                            MaxCountOfEnemy--;
                            Instantiate(EnemyPrefab, new Vector2(i, a), Quaternion.identity, Container.transform);
                            UI.enemyCount = 1;
                            GameManager.enemyCount = 1;
                        }
                    }
                             
                     

                }
            }
        }

        if (MaxCountOfEnemy != 0)
        {
            Instantiate(EnemyPrefab, new Vector2(18, Random.Range(0, 10)), Quaternion.identity, Container.transform);

            UI.enemyCount = 1;
            GameManager.enemyCount = 1;
        }




    }


    void Cleaner()
    {
        foreach (Transform child in Container.transform) Destroy(child.gameObject);
    }
}
