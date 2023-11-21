using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : StateMachineBehaviour
{
    public GameObject Bullet;
    public float BulletSpeed;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        GameObject b = Object.Instantiate(Bullet, animator.gameObject.transform);
        b.transform.localPosition = Vector2.zero;
        b.GetComponent<Rigidbody2D>().AddForce(Vector2.up * BulletSpeed);

        b = Object.Instantiate(Bullet, animator.gameObject.transform);
        b.transform.localPosition = Vector2.zero;
        b.GetComponent<Rigidbody2D>().AddForce(Vector2.down * BulletSpeed);

        b = Object.Instantiate(Bullet, animator.gameObject.transform);
        b.transform.localPosition = Vector2.zero;
        b.GetComponent<Rigidbody2D>().AddForce(Vector2.right * BulletSpeed);

        b = Object.Instantiate(Bullet, animator.gameObject.transform);
        b.transform.localPosition = Vector2.zero;
        b.GetComponent<Rigidbody2D>().AddForce(Vector2.left * BulletSpeed);

    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       
    }
}
