using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralScript : MonoBehaviour
{
    public static float bottom;
    public static float top;
    public static float left;
    public static float right;
    public Transform invader;
    public int numInvaders = 4;

    // Start is called before the first frame update
    void Start()
    {
        top = Camera.main.orthographicSize;
        bottom = -top;
        right = top * Camera.main.aspect;
        left = -right;
        for (int i = 0; i < numInvaders; i++)
        {
            float randomX = Random.Range(left,right);
            float randomY = Random.Range(0, top);
            Vector3 position = new Vector3(randomX, randomY, 0);
            Instantiate(invader, position, transform.rotation);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
