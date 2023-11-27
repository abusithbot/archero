using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[CreateAssetMenu(fileName ="KillCount")]

public class KillCount : ScriptableObject
{
    private TextMeshProUGUI T;
    private int _count;
    [SerializeField]

   public int count { get 
        { return _count; } 
        set 
        { _count=value;
            Debug.Log(_count);

            GameObject TextMeshProGameobjectRef = GameObject.Find("Value");
            T = TextMeshProGameobjectRef.GetComponent<TextMeshProUGUI>();
            T.text = _count.ToString();

            if(count == 10) 
            {
                Time.timeScale = 0;
                GameObject.Find("Canvas").transform.Find("reward pannel").gameObject.SetActive(true);
            }

        } 
    }
    private void OnEnable()
    {
        _count=0;
    }
    void Start()
    {
        GameObject TextMeshProGameobjectRef = GameObject.Find("Value");
        T = TextMeshProGameobjectRef.GetComponent<TextMeshProUGUI>();

        _count = 0;
    }

    private void Update()
    {
        T.text = _count.ToString();
        _count ++;
    }
}
