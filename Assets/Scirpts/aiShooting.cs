using UnityEngine;
using System.Collections;

public class aiShooting : MonoBehaviour {
    public float speed = 30;
    public Rigidbody projectiles;
    public GameObject gun;
    public Rigidbody player;
    RaycastHit hit;


    public void shoot(){
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(gun.transform.position, fwd * 2, out hit, 20f))
        {
            if (hit.collider.tag.Equals("Player"))
            {
                Rigidbody instantiateProjectiles = Instantiate(projectiles, gun.transform.position, gun.transform.rotation) as Rigidbody;
                instantiateProjectiles.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            }
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
