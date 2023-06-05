using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyed : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pop;
    public Transform target; 
    public GameObject chicken;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("rabbit")) // Kiểm tra va chạm với đối tượng B
        {
            Destroy(gameObject); // Hủy bỏ đối tượng A
        }
    }
     

    void OnDestroy()
    {
        Instantiate(pop, transform.position, Quaternion.identity);
        Instantiate(chicken, target.position, Quaternion.identity);
    }
}
