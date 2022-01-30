using UnityEngine;
using UnityEngine.Events;

public class DetectorTrigger : MonoBehaviour
{
    [SerializeField]
    private string validTag = "";

    public UnityEvent validate;

    [SerializeField]
    private GroupValidator groupValidator;

    private bool isPlaced = false;
    private bool isValid = false;

    public bool GetIsValid => isValid;


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
