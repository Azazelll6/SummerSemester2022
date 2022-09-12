using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.TextCore.LowLevel;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent;

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
            matchEvent.Invoke();
            //Debug.Log("Matched");
        }
        else
        {
            noMatchEvent.Invoke();
            //Debug.Log("No Match");
        }
    }
}
