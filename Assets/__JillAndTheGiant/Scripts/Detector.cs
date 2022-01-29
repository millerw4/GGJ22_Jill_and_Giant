using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Detector : MonoBehaviour
{
    [SerializeField]
    private string validTag = "";

    public UnityEvent validate;

    private bool isPlaced = false;
    private bool isValid = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        Debug.Log(isValid);
    }

    private void OnCollisionEnter(Collision collision)
    {
        isPlaced = true;

        if (collision.collider.gameObject.CompareTag(validTag)? collision.collider.gameObject.CompareTag(validTag):false )
        {
            isValid = true;
            validate.Invoke();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        isPlaced = false;
        isValid = false;
    }
}
