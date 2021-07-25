using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlippingBar : Bar
{
    private float lerpSpeed;

    public float targetDirection;
    public float curDirection;

    public float yscale;

    void Start()
    {
        lerpSpeed = 10;

        curDirection = 1;
        targetDirection = 1;
        yscale = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        curDirection = Mathf.Lerp(curDirection, targetDirection, lerpSpeed * Time.deltaTime);
        transform.localScale = new Vector2(transform.localScale.x, yscale * curDirection);
    }

    override public void Move(int dir)
    {
        targetDirection *= -1;
    }

    public override bool CheckAligned()
    {
        if (targetDirection == -1) return true;
        else return false;
    }
}
