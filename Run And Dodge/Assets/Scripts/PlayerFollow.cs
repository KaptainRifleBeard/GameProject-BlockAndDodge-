using UnityEngine;

public class PlayerFollow : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

	
	// Update is called once per frame
	void Update ()
    {
        // lowercase transform refers to the object it is sitting on
        transform.position = player.position + offset;
	}
}
