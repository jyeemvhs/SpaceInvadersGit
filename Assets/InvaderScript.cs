using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderScript : MonoBehaviour
{
    public float invaderSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -invaderSpeed * Time.deltaTime, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        print("OnTriggerEnter");
        if (other.tag.Equals("CannonBall"))
        {
            //            Destroy(other.gameObject);
      //      GameObject.Find("Main Camera").GetComponent<GeneralScript>().GameOver();

            other.GetComponent<CBScript>().GetRidOfMe();
            Destroy(gameObject);
        }
    }
}



