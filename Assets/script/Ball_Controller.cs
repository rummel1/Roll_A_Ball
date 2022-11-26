using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball_Controller : MonoBehaviour
{
    public Rigidbody rb;

    public int speed;

    public int counter;

    public int objectNumber;

    public Text score;

    public Text endgame;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 vector = new Vector3(horizontal, 0, vertical);
        rb.AddForce(vector*speed);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        counter++;
        score.text = "Score: " + counter;
        if (counter == objectNumber)
        {
            endgame.gameObject.SetActive(true);
            score.gameObject.SetActive(false);
            
            
        }
    }
}
