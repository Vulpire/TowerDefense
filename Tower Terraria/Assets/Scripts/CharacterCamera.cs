using UnityEngine;
using System.Collections;


public class CharacterCamera : MonoBehaviour {

    public Transform player;
    public float CameraDistace = 30f;

    private void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height) / CameraDistace);
    }

    void FixedUpdate () {
        transform.position = new Vector3(player.position.x,player.position.y, -20);
	}
}
