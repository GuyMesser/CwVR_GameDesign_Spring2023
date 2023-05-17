using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            Debug.Log("Hit Coin");

        }

        {
            if (collision.gameObject.tag == "Enemy")
            {
                Destroy(gameObject);
                Debug.Log("Hit Enemy");

            }

        }



    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
