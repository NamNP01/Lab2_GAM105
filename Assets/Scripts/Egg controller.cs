using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject EggBroken;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("dat"))
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (col.gameObject.name.Equals("Egg"))
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (col.gameObject.name.Equals("Farmer"))
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (col.gameObject.name.Equals("Box"))
        {
            Destroy(gameObject);
        }
    }
}
