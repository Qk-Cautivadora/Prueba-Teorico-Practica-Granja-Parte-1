using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMEMANAGER : MonoBehaviour
{   //TODOS LOS CANVAS
    [SerializeField]
    GameObject canvasPrincipal, canvasCrear, infoCamara, cerrarCamara;
    //objeto
    public GameObject ObjetoACrear;


    private void Start()
    {
        canvasCrear.SetActive(false);
        infoCamara.SetActive(false);
        cerrarCamara.SetActive(false);
    }

    public void botonCancelarCrear()
    {
        canvasCrear.SetActive(false);
        canvasPrincipal.SetActive(true);
    }
    public void botonCrear()
    {
        canvasCrear.SetActive(true);
        canvasPrincipal.SetActive(false);
    }
    public void botonCamara()
    {
        infoCamara.SetActive(true);
        cerrarCamara.SetActive(true);
        canvasPrincipal.SetActive(false);

    }
    public void botonCerrarinfo()
    {
        infoCamara.SetActive(false);
    }
    public void botonCancelarCamara()
    {
        cerrarCamara.SetActive(false);
        canvasPrincipal.SetActive(true);
    }
   public void  Posobj()
    {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            ObjetoACrear.SetActive(false);
            if (Physics.Raycast(ray, out hit))
            {
                ObjetoACrear.transform.position = hit.point + ((Vector3.up * ObjetoACrear.transform.localScale.y) / 2);
            }  
        ObjetoACrear.SetActive(true);
            if (Input.GetMouseButtonUp(0)) ObjetoACrear = null;



    }
    public void instanciar(GameObject obj)
    {
        ObjetoACrear = Instantiate(obj, Vector3.zero, Quaternion.identity);
        
    }
}