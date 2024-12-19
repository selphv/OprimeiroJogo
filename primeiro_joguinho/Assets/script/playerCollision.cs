using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMoviment movement;

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;

            //chama o parrametro sem precisar colocar ele na interface unity
            FindObjectOfType<GamerManager>().EndGame();
        }
    }

}
