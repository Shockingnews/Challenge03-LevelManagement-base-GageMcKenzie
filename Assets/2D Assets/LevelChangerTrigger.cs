using UnityEngine;

public class LevelChangerTrigger : MonoBehaviour
{
    public LevelManger levelManger;

    private void Start()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D colider)
    {

        if (colider.CompareTag("Player"))
        {
            Debug.Log("hi");
            levelManger.LevelChange();
        }
            
        
        
    }

    
}
