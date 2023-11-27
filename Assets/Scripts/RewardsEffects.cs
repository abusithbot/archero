using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RewardsEffects : MonoBehaviour
{
    public UnityEvent AfterEnnemiDeath;
    public UnityEvent AfterAttack;
     void CreateBonusBullet() 
    {
        Debug.Log("create bonus bullet");    
    }
   void DoubleAttack() 
    {
        Debug.Log("Double attack");    
    }

    public void AddDoubleAttack()
    {
        AfterEnnemiDeath.AddListener(DoubleAttack);
        Time.timeScale = 1;
        GameObject.Find("Canvas").transform.Find("reward pannel").gameObject.SetActive(false);
    }
}
