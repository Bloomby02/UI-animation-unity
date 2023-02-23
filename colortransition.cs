using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colortransition : MonoBehaviour
{
 //image component that will transition it's color
 [SerializeField] private Image thisimage;
 //the color the image will transition to
 [SerializeField] private Color targetcolor;
 //duration of the transition
 [SerializeField] private float duration;

 //use this so the coroutine can be called from button and event trigger
 public void callcolorhange(){
 StartCoroutine( colorchange(thisimage.color, targetcolor));
 }
 
 //function that will transition the color
 public IEnumerator colorchange(Color current, Color target){
 float elapsedtime = 0;
 while(duration >= elapsedtime){
 elapsedtime += Time.deltaTime;
 thisimage.color = Color.Lerp(current, target, (elapsedtime / duration));
 yield return null;
 }
 }
}
