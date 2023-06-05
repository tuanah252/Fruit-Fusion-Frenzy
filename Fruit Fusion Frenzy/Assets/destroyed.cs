using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyed : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pop;
    public GameObject chicken;
    private GameObject prefab;
    public string targetTag;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
     

    void OnDestroy()
    {
        Instantiate(pop, transform.position, Quaternion.identity);
        
    }
}
