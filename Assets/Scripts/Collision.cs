using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public KillCount KillCount;
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        Debug.Log("collision");
        anim.SetTrigger("death");
        Destroy(collision.gameObject);
        KillCount.count++;

     
    }
    public Animator anim;

    
    // Start is called before the first frame update

}
