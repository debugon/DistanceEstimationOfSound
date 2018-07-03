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
        transform.localScale = Vector3.one * volume;
	}
}
