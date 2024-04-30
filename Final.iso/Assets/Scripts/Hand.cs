using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Hand : MonoBehaviour
{

    float zPos = -2;
    float ogZ;
    float timer = 0;
    float duration = 10;
    bool click = false;
    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        //   animator = GetComponent<Animator>();
        ogZ = transform.position.z;
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!GameManager.instance.isGameOver)
        {
            
            claw();
            //animator.SetBool("click", click);
            if (zPos > -2)
            {
                timer++;

                if (timer >= duration)
                {
                    zPos = ogZ;
                    transform.position = new Vector3(transform.position.x, transform.position.y, zPos);
                    timer = 0;
                }
            }
           
            //insert lerping here


            Debug.Log(timer);
        }
    }

        public Vector3 GetWorldPositionOnPlane(Vector3 screenPosition, float z)
        {
            Ray ray = Camera.main.ScreenPointToRay(screenPosition);
            Plane xyz = new Plane(Vector3.forward, new Vector3(0, 0, zPos));
            float distance;
            xyz.Raycast(ray, out distance);
            return ray.GetPoint(distance);
        }

        public void claw()
        {

            if (Input.GetMouseButton(0))
            {
                zPos++;
                transform.position= new Vector3(transform.position.x, transform.position.y, zPos);
                click = true;
             }
        }
    
}
