using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class NewBehaviourScript : MonoBehaviour
{
    private TextMeshProUGUI componenteTexto;
    private AudioSource _audioSource;
    private string mensagemOriginal;
    public bool imprimindo;
    public  float tempoEntreLetras = 0.08f;

    private void Awake()
    {
        TryGetComponent(out componenteTexto);
        TryGetComponent(out _audioSource);
        mensagemOriginal = componenteTexto.text;
        componenteTexto.text = "";
    }

    private void OnEnable()
    {
        ImprimirMensagem (mensagemOriginal);
    }

    private void OnDisable()
    {
        componenteTexto.text = mensagemOriginal;
        StopAllCoroutines();
    }

    public void ImprimirMensagem(string msg)
    {
        if(gameObject.activeInHierarchy)
        {
            if (imprimindo) return;
            imprimindo = true;
            StartCoroutine(LetraPorLetra(msg));
        }
    }

    IEnumerator LetraPorLetra(string msg)
    {
       string mensagem = "";
       foreach(var letra in msg){
        mensagem += letra;
        componenteTexto.text = mensagem;
        _audioSource.Play();
         yield return new WaitForSeconds(tempoEntreLetras);
       }
       imprimindo = false;
       StopAllCoroutines();
    }
}
