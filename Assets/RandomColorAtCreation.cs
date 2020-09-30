using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorAtCreation : MonoBehaviour {
    public SpriteRenderer m_renderer;


	// Use this for initialization
	void Start () {
        m_renderer.color = Random.ColorHSV();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
