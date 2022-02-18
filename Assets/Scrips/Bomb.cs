using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] GameObject CrossBurst;
    [SerializeField] GameObject VerticalBurst;
    void Start()
    {
        StartCoroutine("timer");
    }

    IEnumerator timer()
    {

        yield return new WaitForSeconds(5f);
   
        int x = (int)transform.position.x % 2;
        int y = (int)transform.position.y % 2;


        if ((x == 0) && (y == 0))
        {
            Explosion("Vertical and Horizontal");
        }
        else if (x == 0)
        {
            Explosion("Only Horizontal");
        }
        else
        {
            Explosion("Only Vertical");
        }

        Destroy(gameObject);
    }

    private void Explosion(string explosionDirection)
    {
        switch (explosionDirection)
        {
            case "Vertical and Horizontal":
                Instantiate(CrossBurst, transform.position, Quaternion.identity);

                break;

            case "Only Horizontal":
                Instantiate(VerticalBurst, transform.position, Quaternion.identity);
                break;
            case "Only Vertical":
                Instantiate(VerticalBurst, transform.position, Quaternion.AngleAxis(90, new Vector3(0, 0, 90)));
                break;
            default:
                break;
        }
    }
}
