using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int Speed = 4;
    Rigidbody2D PlayerBody;
    Vector2 MoveDir;
    [SerializeField] GameObject BombPrefab;
    AnimationControler animation;
    bool BombReload = false;
    private void Start()
    {
        PlayerBody = GetComponent<Rigidbody2D>();
        MoveDir = Vector2.zero;
        animation = GetComponent<AnimationControler>();
    }

    public void MoveStart(int directionNumber)
    {
        animation.Run = true;
        switch (directionNumber)
        {
            case 1:
                MoveDir = Vector2.up;
                transform.position = new Vector3(Mathf.Round(transform.position.x), transform.position.y, -2);
                break;
            case 2:
                MoveDir = Vector2.down;
                transform.position = new Vector3(Mathf.Round(transform.position.x), transform.position.y,-2);
                break;
            case 3:
                MoveDir = Vector2.left;
                transform.position = new Vector3(transform.position.x, Mathf.Round(transform.position.y),-2);
                break;
            case 4:
                MoveDir = Vector2.right;
                transform.position = new Vector3(transform.position.x, Mathf.Round(transform.position.y),-2);
                break;
            default:
                break;
        }

    }

    public void MoveStop()
    {
        MoveDir = Vector2.zero;
        animation.Run = false;

    }
    private void FixedUpdate()
    {
        PlayerBody.velocity = MoveDir * Speed;
    }





    public void InstantiateBomb()
    {
        if (BombReload != true)
        {
            Instantiate(BombPrefab, new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y), -3), Quaternion.identity);
            BombReload = true;
            StartCoroutine("reloadBomb");
        }
       
    }



    IEnumerator reloadBomb()
    {

        yield return new WaitForSeconds(5f);
        BombReload = false;
    }







    }
