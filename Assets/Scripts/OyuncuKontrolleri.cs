using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrolleri : MonoBehaviour {

    public float ucusGucu;
    private Rigidbody2D rigidBody;
    public bool oyunBasladi;
    public bool oyunBitti;
    public int puan;
    public GameObject oyunBittiPaneli;
        
	// Use this for initialization
	void Start () {

        rigidBody = GetComponent< Rigidbody2D > ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1") && !oyunBitti)
        {
            if (!oyunBasladi) {
                rigidBody.gravityScale = 1;
                oyunBasladi = true;
            }

            Uc();

        }
	}

    private void FixedUpdate()
    {
        if (oyunBasladi && !oyunBitti)
        {
            UcusAcisi();
        }
    }

    void Uc()
    {
        rigidBody.velocity = Vector2.zero;
        rigidBody.AddForce(new Vector2(0, ucusGucu));
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "OlumAlani")
        {

            oyunBitti = true;
            StartCoroutine(OyunBitti());
        }
        
        if (other.tag == "PuanAlani")
        {
            puan++;

        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "OlumAlani")
        {
            
            oyunBitti = true;
            StartCoroutine(OyunBitti());
        }
    }

    void UcusAcisi ()
    {
        float aci = 35;
        
        if (rigidBody.velocity.y < 0)
        {
            aci = Mathf.Lerp(35, -50,-(rigidBody.velocity.y)/10) ;
        }

        transform.rotation = Quaternion.Euler(0,0,aci);

    }

    IEnumerator OyunBitti()
    {
        yield return new WaitForSeconds(0);
        oyunBittiPaneli.SetActive(true);
        Time.timeScale = 0;
            
    }

}
