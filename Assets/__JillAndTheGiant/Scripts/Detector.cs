using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Detector : MonoBehaviour
{
    [SerializeField]
    private string validTag = "";

    public UnityEvent validate;

    [SerializeField]
    private GroupValidator groupValidator;

    private bool isPlaced = false;
    private bool isValid = false;

    public bool GetIsValid => isValid;

    private void OnCollisionEnter(Collision collision)
    {
        isPlaced = true;

        if (collision.collider.gameObject.CompareTag(validTag) ? collision.collider.gameObject.CompareTag(validTag) : false)
        {
            isValid = true;
            validate.Invoke();
            if (groupValidator == null)
            {
                return;

            }
            groupValidator.CheckValidations();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        isPlaced = false;
        isValid = false;
    }
    private void OnTriggerEnter(Collider collider)
    {
        isPlaced = true;

        if (collider.gameObject.CompareTag(validTag) ? collider.gameObject.CompareTag(validTag) : false)
        {
            isValid = true;
            validate.Invoke();
            if (groupValidator == null)
            {
                return;

            }
            groupValidator.CheckValidations();
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        isPlaced = false;
        isValid = false;
    }
}
