using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Player_Script : MonoBehaviour
    {
        public static bool allDead= false;
        Rigidbody rb;
        private float speed = 5;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
          
        }

        // Update is called once per frame
        void Update()
        {
            float xMove = Input.GetAxisRaw("Horizontal");

            float zMove = Input.GetAxisRaw("Vertical");

            //movement, except for the Y
            rb.velocity = new Vector3(xMove * speed, rb.velocity.y, zMove * speed);
            
        }

 
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("DNF"))
            {
                GameManager.instance.GameOver();
            }
            if(other.gameObject.CompareTag("Enemy"))
            {
                allDead = true;
            }
        }

        
    }
}