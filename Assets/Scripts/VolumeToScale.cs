using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class VolumeToScale : MonoBehaviour {

    private float[] waveData = new float[1024];
    
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        AudioListener.GetOutputData(waveData, 1);
        var volume = waveData.Select(x => x * x).Sum() / waveData.Length;
        //transform.localScale = new Vector3(1, volume * 100, 1);
        GetComponent<RectTransform>().sizeDelta = new Vector2(100, volume * 100000);
        GetComponent<RectTransform>().localPosition = new Vector3(0, GetComponent<RectTransform>().sizeDelta.y / 2 - 50, 0);
        Debug.Log((GetComponent<RectTransform>().sizeDelta.y / 2.0f) );
    }
}
