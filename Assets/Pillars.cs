using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillars : MonoBehaviour
{
    public float speed = 2f;

    public float lowerXValue = -20f;

    public float upperXValue = 40;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
        if (transform.position.y <= lowerXValue)
        {
            transform.Translate(0f, upperXValue, 0f);
        }
    }
}
