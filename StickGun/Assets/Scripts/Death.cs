using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour
{
    public Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
     click();
    }

    void click()
    {
        
            
                anim.Play("death");
            
            
    }
        /*if (Input.GetMouseButtonDown(0)){
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Collider2D.OverLapPoint(mousePosition))
            {
                
            }


        }*/
        /*void OnCollisionEnter2D(Collision2D col)
            {
                if (col.gameObject.tag == "enemy")
                {
                    Destroy(col.gameObject);
                }
            }
        }*/
   
}
