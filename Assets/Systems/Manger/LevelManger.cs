using UnityEngine;

public class LevelManger : MonoBehaviour
{
    public GameObject level1;
    public GameObject level2;
    private GameObject player;

    public bool locked;

    private GameObject currentLevel;
    private void Start()
    {
        player = ServiceHub.Instance.playerController.gameObject;
        currentLevel = level1;
        level1.SetActive(true);
        level2.SetActive(false);
        
    }
    
    public void LevelChange(GameObject level,Transform position)
    {
        
        

            level.SetActive(true);
            currentLevel.SetActive(false);
            player.transform.position = position.transform.position;
            currentLevel = level;
            
       
        

    }
}
