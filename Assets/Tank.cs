using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed = 10;
    public float rotSpeed = 90;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // deltaTime will have 1/60
        transform.Translate(0, 0, speed * Time.deltaTime * Input.GetAxis("Vertical"));
        //Translate(0, 0, 1) -> Move the position of this game object 1 unit every frmae
        transform.Rotate(0, rotSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0);

    }
}
