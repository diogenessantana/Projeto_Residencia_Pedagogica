using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscolhaDoUsuario : MonoBehaviour
{
    public void PermutacaoEscolher(GameObject check)
    {
        DataPlay.escolhaDoMenu = "permutacao";
    }

    public void ArranjoEscolher(GameObject check)
    {
        DataPlay.escolhaDoMenu = "Arranjo";
    }

    public void CombinacaoEscolher(GameObject check)
    {
        DataPlay.escolhaDoMenu = "combinacao";
    }

    /*
     * O c�digo abaixo � referente ao
     * comportamento do campo de entra-
     * da. Guardar o valor digitado pelo
     * usu�rio
     */
    
}
