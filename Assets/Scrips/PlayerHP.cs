using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
 
    public System.Action PlayerLose;
    void Start()
    {
    
    }

   public void IsDead()
    {
        PlayerLose?.Invoke();
      
    
    }
}
