using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public KillCount KillCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("Ca marche bg");
        KillCount.count = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
