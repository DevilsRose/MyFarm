using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemey : MonoBehaviour
{
    public bool isTouching;
    [SerializeField]

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }
        private void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.tag =="Enemy")
        {
            isTouching = true;
        }
        
    }

    private void OnCollisionExit2D(Collision2D other) 
    {
        {
            if(other.collider.tag =="Enemy")
            {
                isTouching = false;
              
    }   }   }
}
