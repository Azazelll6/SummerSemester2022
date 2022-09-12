using System;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(idObj);
        //Debug.Log(other.GetComponent<IDContainerBehavior>().idObj);
        var tempObj = other.GetComponent<IDContainerBehavior>();
        if (tempObj == null)
            return;

        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            Debug.Log("Matched");
        }
        else
        {
            Debug.Log("No Match");
        }
    }
}
