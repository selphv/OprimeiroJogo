using UnityEngine;

public class playerMoviment : MonoBehaviour
{
    //declaração de atributo tirando a da iterfane unit para poder mexer com ela no script
    public Rigidbody  rb;

    /*
        quando vc coloca um public com algum falar de atribuiçao,ele vai parar na interface
        da unity para ser mexida la sem precisar trocar no scripy
    */

    //public de velocidade horizontal,feita para mexer na interface
    public float forwardForce = 2000f;

    //public de velocidade lateral,|| 
    public float sidewaysForce = 500f;

    // faz atualização de frame no jogo 

    void FixedUpdate ()
    {
        /*rb.AddForce(x,y,z)
                      l,h,ft
         legenda:
            l = laterais 
            h = horizontais 
            ft = frente e traz

         */
        //comando de starte de velocidade horizontal 
        rb.AddForce(0 , 0 ,forwardForce * Time.deltaTime);

        //comande: 'Inupt.GetKey',indentificar a tecla
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GamerManager>().EndGame();
        }


    }
}
