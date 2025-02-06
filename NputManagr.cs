using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NputManagr : MonoBehaviour
{

    private PlyrNput plyrNput;
    private PlyrNput.OnFootActions onFt;

    private PlyrMotr motr;
    // Start is called before the first frame update
    void Awake()
    {
        plyrNput = new PlyrNput();
        onFt = plyrNput.OnFoot;
        motr = GetComponent<PlyrMotr>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Lettuce know hom much moving we doin'
        motr.ProcessMove(onFt.Move.ReadValue<Vector2>());
    }

    //To use the movement 
    private void OnEnable()
    {
        onFt.Enable();
    }
    private void OnDisable()
    {
        onFt.Disable();
    }
}
