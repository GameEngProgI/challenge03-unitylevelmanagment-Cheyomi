using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject level01;
    public Transform player;

    private GameObject currentActiveLevel;
    
    public void Start()
    {
        currentActiveLevel = level01;
        level01.SetActive(true);
    }

    public void LevelChange(GameObject level,Transform spawnpoint)
    {
        currentActiveLevel.SetActive(false);
        level.SetActive(true);
        currentActiveLevel = level;
        player.position = spawnpoint.position;
    }
}



