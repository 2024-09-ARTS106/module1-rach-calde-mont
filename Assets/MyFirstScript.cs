using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    public int frameNum;
   // Start is called before the first frame update
    void Start()
    { 
     Debug.Log ("I was told to start" + this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
      //Debug.Log("Frame {0}: Update at frame #{1}", frameNum, Time.time);
      Debug.Log ("Frame" + frameNum + "Update at Time" + Time.time);
        frameNum = frameNum + 1;
    }
}
