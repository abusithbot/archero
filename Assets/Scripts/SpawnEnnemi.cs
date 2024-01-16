using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnnemi : MonoBehaviour
{
    public GameObject Ennemi;
    public Transform spawnPoint;
    public int NumberEnnemi = 5;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnnemi", 0.1f, 0.5f);        
    }

    void SpawnEnnemies()
    {
        for (int i = 0; i < NumberEnnemi; i++) ;
        {
            Instantiate(Ennemi, spawnPoint.position,Quaternion.identity);
        }
    }



// Update is called once per frame
void Update()
    {
        
    }
}
