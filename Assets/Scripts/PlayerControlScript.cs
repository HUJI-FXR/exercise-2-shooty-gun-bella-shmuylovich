using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{
    #region VARIABLES

    private MovementScript _movementScript;


    #endregion

    #region MONOBEHAVIOUR

    void Start()
    {
        _movementScript = GetComponent<MovementScript>();
    }

    void Update()
    {
        GetInput();
        print(GetComponent<Rigidbody2D>().velocity);
    }

    #endregion

    #region HELPERS

    private void GetInput()
    {
        // check movement
        if (Input.GetKey(KeyCode.A)) _movementScript.Move(-1f);
        else if (Input.GetKey(KeyCode.D)) _movementScript.Move(1f);
        // check jump
        if (Input.GetKey(KeyCode.W)) _movementScript.Jump();
    }

    #endregion
   
}
