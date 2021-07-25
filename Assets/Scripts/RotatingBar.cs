using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBar : Bar
{
    public float step;
    private float lerpSpeed;

    public float targetAngle;
    public float curAngle;

    void Start()
    {
        step = 45;
        lerpSpeed = 10;

        curAngle = transform.eulerAngles.z;
        targetAngle = curAngle;
    }

    // Update is called once per frame
    void Update()
    {
        curAngle = Mathf.Lerp(curAngle, targetAngle, lerpSpeed * Time.deltaTime);
        transform.eulerAngles = new Vector3(0, 0, curAngle);
    }

    override public void Move(int dir)
    {
        targetAngle += step * dir;
    }

    public override bool CheckAligned()
    {
        if (-0.0001 < targetAngle && targetAngle < 0.0001)
            return true;
        else
            return false;
    }
}
