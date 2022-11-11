using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField] float delayReloadScene = 0.5f;
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] AudioClip finishSFX;
   
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            finishEffect.Play();

            GetComponent<AudioSource>().PlayOneShot(finishSFX);

            Invoke("ReloadScene", delayReloadScene);
     
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);

    }
}
