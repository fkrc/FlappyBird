using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boru : MonoBehaviour {

    public float minAralik;
    public float maxAralik;

    public GameObject ust;
    public GameObject alt;

    private SpriteRenderer ustRend;
    private SpriteRenderer altRend;


	// Use this for initialization
	void Start () {

        Setup();
		
	}
	
	// Update is called once per frame
	void Update () {

        boruKaldir();
		
	}

    void Setup()
    {
        ustRend = ust.GetComponent<SpriteRenderer>();
        altRend = alt.GetComponent<SpriteRenderer>();
               
        float gecici = Random.Range(-1.05f + minAralik, 3);
        ust.transform.position = new Vector2(transform.position.x, gecici);

        float gecici2 = Random.Range(minAralik, maxAralik);
        alt.transform.position = new Vector2(transform.position.x, gecici - gecici2);

    }

    void boruKaldir ()
    {
        if (transform.position.x < 0)
        {
            if (!ustRend.isVisible && !altRend.isVisible)
            {
                Destroy(this.gameObject);
            }

        }

    }
}
