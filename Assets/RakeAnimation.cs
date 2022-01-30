using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RakeAnimation : MonoBehaviour
{
    [SerializeField]
    private Animation ani;

    [SerializeField]
    private Transform pivot1;
    [SerializeField]
    private Transform pivot2;



    public void PlayAni()
    {
        pivot1.localRotation = Quaternion.Euler(-3.0f,0.0f,0.0f);
        pivot2.localRotation = Quaternion.Euler(-24.0f, 180.0f, 0.0f);
    }

}
