using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickencontroller : MonoBehaviour
{
    public GameObject egg;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if(count>200)
        {
            Instantiate(egg, transform.position,Quaternion.identity);
            count = 0;
        }
    }
}
