using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //playerMovement
    private CharacterController charControl;
    private Vector3 PlayerVelocity;
    private float Playerspeed = 5;
    private float translation;
    private float straffe;

    //hand
    public GameObject Hand;
    public float Hd;
    private float mouseSensitivity = 5f;

    //mouse
    Transform cameraTrans;

    //score
    public float score = 0;

    // Start is called before the first frame update
    void Start()
    {
        charControl = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        cameraTrans = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        


        translation = Input.GetAxis("Vertical") * Playerspeed * Time.deltaTime;
        straffe = Input.GetAxis("Horizontal") * Playerspeed * Time.deltaTime;
        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        

    }

    private void Enter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            
            
    
        }
    }
}
