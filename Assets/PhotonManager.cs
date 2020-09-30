using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonManager : MonoBehaviourPunCallbacks{

	// Use this for initialization
	void Start () {
        PhotonNetwork.ConnectUsingSettings();

       

    }

   /* public override void OnJoinedLobby()
    {
        Debug.Log("Lobby Joinded");
        RoomOptions currentOptions = new RoomOptions();

        currentOptions.MaxPlayers = 2;

        PhotonNetwork.JoinOrCreateRoom("Room", currentOptions, TypedLobby.Default);
    }*/

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
       
    }

    public override void OnJoinedLobby()
    {
        RoomOptions currentOptions = new RoomOptions();

       currentOptions.MaxPlayers = 5;

       PhotonNetwork.JoinOrCreateRoom("Room", currentOptions, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        Vector3 objectPos = Vector3.zero;
        float maxX = 150f;
        float maxY = 150f;
        float maxZ = 150f;

        objectPos.x = Random.Range(-maxX, maxX);
        objectPos.y = Random.Range(-maxY, maxY);

        PhotonNetwork.Instantiate("Player", objectPos, Quaternion.identity);
        //PhotonNetwork.Instantiate();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
