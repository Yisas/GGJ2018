using UnityEngine;

//simple class to add to checkpoint triggers
public class Checkpoint : MonoBehaviour 
{
    public GameObject spawnPosition;
	//setup
	void Awake()
	{
		if(tag != "Respawn")
		{
			tag = "Respawn";
			Debug.LogWarning ("'Checkpoint' script attached to object without the 'Respawn' tag, tag has been assigned automatically", transform);	
		}
		GetComponent<Collider>().isTrigger = true;
	}
	
	//more setup
	void Start()
	{

	}
	
	//set checkpoint
	void OnTriggerEnter(Collider other)
	{
		if(other.transform.root.tag == "Player")
		{
            // Set the player's respawn position to the checkpoint's position
            ResettableObject player = other.transform.root.GetComponent<ResettableObject>();
            player.RespawnPosition = spawnPosition.transform.position;
            player.RespawnRotation = transform.rotation;

            // Disable the collider since a checkpoint can only be used once
            GetComponent<BoxCollider>().enabled = false;
		}
    }
}