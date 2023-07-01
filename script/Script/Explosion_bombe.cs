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

    // tempo de la bombe 
    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(Explosion());
        boom.SetTrigger("attack01");
    }

    IEnumerator Explosion()
    {
        yield return new WaitForSeconds(sec);
        Boom = true;
    }

    // quand le CASSABLE est dans la range de la bombe
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
