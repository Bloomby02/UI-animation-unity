using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakeui : MonoBehaviour
{
 //rect transform of ui object that will be shake
 [SerializeField] private RectTransform thisrtransform;
 //shake duration
 [SerializeField] private float duration;
 //shake power
 [SerializeField] private float power;

 //use this so the coroutine can be called from button and event trigger
 public void callshakeui(){
 StartCoroutine( shake(thisrtransform.anchoredPosition));
 }

 //function that will shake the selected ui object
 public IEnumerator shake(Vector2 origin){
 float elapsedtime = 0;
 Vector2 shakevec = Vector2.zero;
 while(duration >= elapsedtime){
 elapsedtime += Time.deltaTime;
 thisrtransform.anchoredPosition = origin+shakevec;
 shakevec = new Vector2(Random.Range(-power, power), Random.Range(-power, power));
 yield return null;
 }
 thisrtransform.anchoredPosition = origin;
 }
}
