using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yer : MonoBehaviour {

    public Transform YerOlusturmaNoktasi;
    public OyuncuKontrolleri oyun;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

       yerDegistirme();
       

    }

    void yerDegistirme ()
    {
        
           if (transform.position.x <= -YerOlusturmaNoktasi.position.x)
         {
            transform.position = YerOlusturmaNoktasi.position;
         }       
    }
}
