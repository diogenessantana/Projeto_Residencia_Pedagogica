using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassagemCenas : MonoBehaviour
{
    public void Avancar(string cena)
    {
        SceneManager.LoadScene(cena);
        Debug.Log(DataPlay.escolhaDoMenu);
    }

    public void Voltar(string cena)
    {
        SceneManager.LoadScene(cena);
    }

    public void Reiniciar(string cena)
    {
        SceneManager.LoadScene(cena);
    }
}
