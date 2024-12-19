using UnityEngine;

public class Endc : MonoBehaviour
{
    public GamerManager gamerManager;

    private void OnTriggerEnter()
    {
        gamerManager.CompleteLevel();
    }

}
