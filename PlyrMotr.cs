using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyrMotr : MonoBehaviour
{
    private CharacterController ctrlr;
    private Vector3 plyrV;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //Removes the "NOT ATTACHED TO OBJECT/ INSTANCE" Error & also makes you actually move the Plyr (THANK CHAT GPT)
        ctrlr = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Collect "Nput"'s for NputManagr.cs and put them on ctrlr
    public void ProcessMove(Vector2 nput)
    {
        Vector3 moveWay = Vector3.zero;
        moveWay.x = nput.x;
        moveWay.z = nput.y;
        ctrlr.Move(transform.TransformDirection(moveWay) * speed * Time.deltaTime);
    }
}
