using UnityEngine;

public class Play : MonoBehaviour
{
    public float velocidade;
    
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3( velocidade * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3( -velocidade * Time.deltaTime, 0, 0);
        }

        
    }
}
