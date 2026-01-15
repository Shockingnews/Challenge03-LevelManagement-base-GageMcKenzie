using UnityEngine;

public class LevelManger : MonoBehaviour
{
    public GameObject level1;
    public GameObject level2;

    private GameObject currentLevel; 

    public void LevelChange()
    {
        level1.SetActive(false);
        level2.SetActive(true);

    }
}
