using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControler : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

  public bool Run
    {
        set
        {
            animator.SetBool("IsRun", value);
        }
        
    }
}
