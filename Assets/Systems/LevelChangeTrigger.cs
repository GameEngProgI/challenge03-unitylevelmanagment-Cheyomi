using UnityEngine;

public class LevelChangeTrigger : MonoBehaviour
{
    public LevelManager levelManager;

    private void Start()
    {
        levelManager = ServiceHub.Instance.levelManager;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Level Change Triggered");
            //tell the level manager to change levels
            levelManager.LevelChange();
        }
    }
}

