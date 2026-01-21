using UnityEngine;

public class LevelChangerTrigger : MonoBehaviour
{
    public LevelManger levelManger;

    public GameObject levelToActivate;
    public Transform spawnPoint;
    public bool locked = false;
    private GameObject player;

    private void Start()
    {
        player = ServiceHub.Instance.playerController.gameObject;
        levelManger = ServiceHub.Instance.levelManger;
        locked = GetComponent<Collider2D>().OverlapPoint(player.transform.position);
    }

    
    private void OnTriggerEnter2D(Collider2D colider)
    {
        

        if (colider.CompareTag("Player") && locked == false)
        {
            Debug.Log("hi");
            levelManger.LevelChange(levelToActivate, spawnPoint);
        }
            
        
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            locked = false;
        }
    }


}
