using UnityEngine;
using System.Collections;

public class WallSpawn : MonoBehaviour
{
    public
    Rigidbody cubeWall;
    [SerializeField]
    Vector3 pos;
    // Use this for initialization
    void Start()
    {
        pos = transform.position;
        //This loop is performed to allow for the postion of cubes to form and create a cubeWall
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Rigidbody instantiateCubes = Instantiate(cubeWall, pos, transform.rotation) as Rigidbody;
                    pos.x += 1;
                }
                pos.x = transform.position.x;
                pos.y += 1;
            }
            pos.x = transform.position.x;
            pos.y = transform.position.y;
            pos.z += 1;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }


}