using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    AnimationControler animation;
    int Speed = 1;
    Rigidbody2D Body;
    Vector2 MoveDir;
    private void Start()
    {
        animation = GetComponent<AnimationControler>();
        Body = GetComponent<Rigidbody2D>();
       
        StartCoroutine("Moving");
    }

    IEnumerator Moving()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(5f);

            MoveDir = new Vector2(Random.Range(-1, 2), 0);
            animation.Run = true;
            yield return new WaitForSeconds(5f);
            
            MoveDir = new Vector2(0, Random.Range(-1, 2));
            yield return new WaitForSeconds(5f);
            
            MoveDir = Vector2.zero;
            animation.Run = false;



        }
        

    }


    private void FixedUpdate()
    {
        Body.velocity = MoveDir * Speed;
    }
}