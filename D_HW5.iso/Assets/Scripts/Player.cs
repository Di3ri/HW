using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
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
        private void OnTriggerEnter(Collider other)
        {
            //kills an Enemy the second it collides with any enemy tag
            if (other.CompareTag("Enemy"))
            {
                //destroy All Enemies
                Destroy(GetComponent<Enemy>());
            }
        }
    }
}
