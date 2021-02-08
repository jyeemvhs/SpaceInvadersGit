using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float cannonSpeed = 10.0f;
    public Transform cannonBall;
    private bool fireCB;
    void Start()
    {
        fireCB = false;
        transform.position = new Vector3(0, GeneralScript.bottom, 0);
    }

    // Update is called once per frame
    void Update()
    {
//        print(Input.GetAxis("Fire1"));



//        if (Input.GetKeyDown("space"))
//            Instantiate(cannonBall, transform.position, transform.rotation);

        
        if (Input.GetAxis("Fire1") == 0)
        {
            fireCB = false;
        }
        else if (!fireCB)
        {
            fireCB = true;
            Instantiate(cannonBall, transform.position, transform.rotation);  //new code.
        }
                

        float xtrans = Input.GetAxis("Horizontal") * Time.deltaTime * cannonSpeed;
        transform.Translate(xtrans, 0, 0);
        if (transform.position.x > GeneralScript.right)
            transform.position = new Vector3(GeneralScript.right, transform.position.y, transform.position.z);
        if (transform.position.x < GeneralScript.left)
            transform.position = new Vector3(GeneralScript.left, transform.position.y, transform.position.z);
    }
}
