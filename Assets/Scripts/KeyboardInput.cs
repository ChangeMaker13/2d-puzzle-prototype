using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    public ObjectController controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            controller.MoveSelected(1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            controller.MoveSelected(-1);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            controller.MoveFootRest(1);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            controller.MoveFootRest(-1);
        }
    }
}
