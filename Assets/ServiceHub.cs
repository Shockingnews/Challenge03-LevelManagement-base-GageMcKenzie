using UnityEngine;

public class ServiceHub : MonoBehaviour
{
    //public PlayerController playerController;
    //public LevelManger levelManger;
    //// Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    // SERVICE HUB PATTERN
    // Provides a centralized registry for game-wide systems (UI, Player, Audio).
    // This eliminates the need for expensive 'Find' calls and reduces 
    // tight coupling by giving scripts a single point of contact for dependencies.

    // Note: This does create a "God Object" which can have downsides if overused.
    // But is a simple useful pattern for beginner programmers for small to mid-sized projects.

    // The static instance that makes this globally accessible
    public static ServiceHub Instance { get; private set; }


    [Header("System References")]
    public PlayerController playerController;
    public LevelManger levelManger;




    private void Awake()
    {
        #region Singleton Pattern

        // Simple singleton setup for a single-scene game
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        #endregion
    }
}
