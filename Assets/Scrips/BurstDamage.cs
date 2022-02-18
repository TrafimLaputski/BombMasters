using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstDamage : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("timer");
    }

    IEnumerator timer()
    {

        yield return new WaitForSeconds(3f);

        Destroy(gameObject);
    }

        private void OnTriggerEnter2D(Collider2D collision)
        {
    


        switch (collision.tag)
        {
            case "Player":
                collision.gameObject.GetComponent<PlayerHP>().IsDead();
                break;
            case "Enemy":
                collision.gameObject.GetComponent<EnemyHealth>().EnemyDead();
                break;

            default:
                Destroy(collision.gameObject);
                break;
        }
    }
}
