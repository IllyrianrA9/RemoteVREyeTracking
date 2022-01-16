using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    private float timeCounter = 0f;
    public float speed = 0.5f;
    public float height;
    public float width;
    private Vector3 _startPosition;
    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * speed;
        //timeCounter += Input.GetAxis("Horizontal") * Time.deltaTime;
        float x = 0;
        float y = Mathf.Sin(timeCounter) * height;
        float z = Mathf.Cos(timeCounter) * width;
        transform.position = _startPosition + new Vector3(x, y, 0);
        
        //transform.eulerAngles = new Vector3(10,10,10);
    }
}
