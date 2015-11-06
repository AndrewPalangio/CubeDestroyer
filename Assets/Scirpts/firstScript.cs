using UnityEngine;
using System.Collections;

public class firstScript : MonoBehaviour
{
    public float speed = 20;
    public Rigidbody cubeBullets;
   

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        //modify x, y, z numbers in editor to change how many bullets are fired in a grid pattern
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody instantiateProj = Instantiate(cubeBullets, transform.position, transform.rotation) as Rigidbody;
            instantiateProj.velocity = transform.TransformDirection(new Vector3(0, speed, 0));
            Debug.Log("shooting");
            Destroy(instantiateProj.gameObject, 1.0f);
        }

    }
}

