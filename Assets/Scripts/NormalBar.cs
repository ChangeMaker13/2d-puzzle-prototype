using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBar : Bar
{
    public Vector2 curPos;
    public Vector2 targetPos;

    public float step = 1;
    private float lerpSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        curPos = transform.position;
        targetPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        curPos = Vector2.Lerp(curPos, targetPos, lerpSpeed * Time.deltaTime);
        transform.position = curPos;
    }

    override public void Move(int dir)
    {
        targetPos.y += step * dir;
    }

    public override bool CheckAligned()
    {
        if (-0.0001 < targetPos.y && targetPos.y < 0.0001)
            return true;
        else
            return false;
    }
}
