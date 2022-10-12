using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public void CambioEscenaClick (string sceneName){
        Debug.Log("CAMBIANDO ESCENA: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }   //FIN CambiarEscenaClick

    public void SalirJuego(){
        Debug.Log("SALIENDO DEL JUEGO");
        Application.Quit();
    }// FIN salirJuego

}// FIN DE LA CLASE
