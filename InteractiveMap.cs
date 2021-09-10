using System;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveMap : MonoBehaviour
{
    [SerializeField] private List<RectTransform> mapPosition;
    [SerializeField] private RectTransform MapRussia;
   
   
    public void CityCall()
    {
        InvokeRepeating("MosowClicK", 0, Time.deltaTime* 1f);
    }
    private void MosowClicK()
    {
        MapRussia.localPosition = new Vector3(Mathf.Lerp(MapRussia.localPosition.x, mapPosition[0].localPosition.x, Time.deltaTime*1f), Mathf.Lerp(MapRussia.localPosition.y, mapPosition[0].localPosition.y, Time.deltaTime*1f), Mathf.Lerp(MapRussia.localPosition.z, mapPosition[0].localPosition.z, Time.deltaTime*1f));
        MapRussia.localScale = new Vector3(Mathf.Lerp(MapRussia.localScale.x, mapPosition[0].localScale.x, Time.deltaTime*1f), Mathf.Lerp(MapRussia.localScale.y, mapPosition[0].localScale.y, Time.deltaTime*1f), Mathf.Lerp(MapRussia.localScale.z, mapPosition[0].localScale.z, Time.deltaTime*1f));
        if(mapPosition[0].localPosition.x - MapRussia.localPosition.x < 10f)
        {
            CancelInvoke();
            print("стоп");
        }
    }

 
}
