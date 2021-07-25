using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Rigidbody2D bikeRigid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveBike()
    {
        StartCoroutine(PushBike());
    }

    private IEnumerator PushBike()
    {
        yield return new WaitForSeconds(1.0f);
        bikeRigid.AddForce(new Vector2(600, 0));
    }
}
