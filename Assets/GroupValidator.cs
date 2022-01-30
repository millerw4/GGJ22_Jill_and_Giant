using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GroupValidator : MonoBehaviour
{
    [SerializeField]
    private List<Detector> detectors;

    public UnityEvent validate;

    public void CheckValidations()
    {
        bool allValid = false;
        foreach (Detector d in detectors)
        {
            allValid = d.GetIsValid;
            if (allValid == false) return;
        }
        validate.Invoke();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
