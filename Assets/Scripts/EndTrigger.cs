using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter ()
    {
        Debug.Log("Hit");
        gameManager.CompleteLevel();
    }
}
