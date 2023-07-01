using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion_bombe : MonoBehaviour
{
    private Animator boom;
    [SerializeField] float sec = 1.9f;
    bool Boom = false;
    public AudioClip explosion;
    // Start is called before the first frame update
    void Start()
    {
        boom = GetComponent<Animator>();
    }

    // si il y a collision 
    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(Explosion());
        boom.SetTrigger("attack01");
    }
    // tempo de la bombe 
    IEnumerator Explosion()
    {
        yield return new WaitForSeconds(sec);
        Boom = true;
    }

    // destuction du cassable 
    private void OnTriggerStay(Collider CASSABLE)
    {
        if (!Boom) return;

        if (CASSABLE.CompareTag("CASSABLE"))
        {
            Destroy(CASSABLE.gameObject);
            AudioSource.PlayClipAtPoint(explosion , transform.position);
        }

        Destroy(gameObject);
    }
    
}
