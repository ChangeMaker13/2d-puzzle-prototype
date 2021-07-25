using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bar : MonoBehaviour
{
    abstract public void Move(int dir);
    abstract public bool CheckAligned();
}
