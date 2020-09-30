using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;


public class PlayerNetworking : MonoBehaviour {
    public PhotonView m_photonView;
    public List<MonoBehaviour> m_scriptsToDisable;

	// Use this for initialization
	void Start () {
		if (!m_photonView.IsMine)
        {
            foreach(MonoBehaviour currentScript in m_scriptsToDisable)
            {
                currentScript.enabled = false;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
      
    }
}
