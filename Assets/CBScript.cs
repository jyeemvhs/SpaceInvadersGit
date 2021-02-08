using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBScript : MonoBehaviour
{
    public float cannonBallSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, cannonBallSpeed*Time.deltaTime, 0);
        if (transform.position.y > GeneralScript.top)
            Destroy(gameObject);
    }
    public void GetRidOfMe()
    {
        Destroy(gameObject);
    }
}
