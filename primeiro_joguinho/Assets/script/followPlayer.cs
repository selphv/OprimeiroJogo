
using UnityEngine;

public class followPlayer : MonoBehaviour
{

    //comando:'Transform',usado para coletar a posiçao,escala e rotaçao de um objeto/player
    public Transform player;
    public Vector3 offset;
   
    
    void Update()
    {
        //comando:faz o possiçao da camera seguir o player,offset: para a camera nao ficar em primeira pessoa ,atruibutos do offset na interface do unity 
        transform.position = player.position + offset;
    }
}
