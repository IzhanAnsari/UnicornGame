using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class eatButtonScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{
     public static bool ispressed = false;

    // Start is called before the first frame update
     void Start () {
 
 }

 void Update()
 {

 }

 public void OnPointerDown(PointerEventData eventData)
 {
     ispressed = true;
 }
 
 public void OnPointerUp(PointerEventData eventData)
 {
     ispressed = false;
 }
}
