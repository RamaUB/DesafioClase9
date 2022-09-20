using UnityEngine;

public class desafio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // 1. Hacer un print de la *posición* del GameObject al cual el script está asociado únicamente cuando se apreta Play.
            //Debug.Log("La posición del GameObject es (X, Y, Z): "+transform.position);

        //2. Hacer un print de la *rotación* del GameObject al cual el script está asociado únicamente cuando se apreta Play.
            //Debug.Log("La rotación del GameObject es "+ transform.rotation);

        //3. Hacer un print de la *escala local* del GameObject al cual el script está asociado únicamente cuando se apreta Play.
            //Debug.Log(transform.localScale);

        //* 4.Movimiento en el eje X positivo de 0.05f
            //transform.position += new Vector3(0.05f, 0, 0);

        //* 5.Movimiento en el eje X negativo de 0.05f
            //transform.position += new Vector3(-0.05f, 0, 0);

        //* 6.Movimiento en el eje Y positivo de 0.1f
            //transform.position += new Vector3(0, 0.1f, 0);

        //* 7.Movimiento en el eje Y negativo de 0.1f
            //transform.position += new Vector3(0, -0.1f, 0);

        //* 8.Movimiento en el eje Z positivo de 0.25f
            //transform.position += new Vector3(0, 0, 0.25f);

        //* 9.Movimiento en el eje Z negativo de 0.25f
            //transform.position += new Vector3(0, 0, 0.25f);

    }

    // Update is called once per frame
    void Update()
    {

        //*10.Rotación * sin detenerse* en el exe X de 15º
            //Vector3 rotarEnX = new Vector3(15, 0, 0);
            //transform.Rotate(rotarEnX);


        //*11.Rotación * sin detenerse* en el exe Y de 30º
            //   Vector3 rotarEnY = new Vector3(0, 30, 0);
            //   transform.Rotate(rotarEnY);


        //* 12.Rotación * sin detenerse* en el exe Z de 60º
            // Vector3 rotarEnZ = new Vector3(0, 0, 60);
            //transform.Rotate(rotarEnZ);

        //* 13.Cambio de escala en el eje X de 1.
            //transform.localScale += new Vector3(1f, 0, 0);

        //    * 14.Cambio de escala en el eje Y de 2.
            //transform.localScale += new Vector3(0, 2f, 0);

        // * 15.Cambio de escala en el eje Z de 3.
            //transform.localScale += new Vector3(0, 0, 3f);

    }
}
