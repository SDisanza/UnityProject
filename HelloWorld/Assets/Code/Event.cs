using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class Event : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    /*public static bool buttonPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }*/
    [Range(1.0f, 10.0f)]
    public float seconds = 1.0f;
    public static UnityEvent onPressedOverSeconds;
 
 
    public void OnPointerDown(PointerEventData eventData)
    {
     
        StartCoroutine(TrackTimePressed());
    }
 
    public void OnPointerUp(PointerEventData eventData)
    {
     
        StopAllCoroutines();
    }
 
    private IEnumerator TrackTimePressed()
    {
        float time = 0;
 
 
        while (time < this.seconds)
        {
            time += Time.deltaTime;
            yield return null;
        }
 
        onPressedOverSeconds.Invoke();
    }
}
