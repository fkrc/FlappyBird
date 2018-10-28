using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Oyun : MonoBehaviour {

    private float zamanlayici;
    public float maxZaman;
    public float minZaman;
    public GameObject boruPrefab;
    public Transform boruOlusturanNokta;

    public OyuncuKontrolleri oyunkontrolleri;
    public Text puan;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (zamanlayici <= 0 && oyunkontrolleri.oyunBasladi == true)
        {
            BoruOlustur();
            Puan();
        }

        zamanlayici -= Time.deltaTime;
	}

    void BoruOlustur()
    {
        Instantiate(boruPrefab, boruOlusturanNokta.position, boruOlusturanNokta.rotation);
        zamanlayici = Random.Range(minZaman, maxZaman);
    }

    void Puan ()
    {
        puan.text = oyunkontrolleri.puan.ToString();
    }

    public void yeniOyun ()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);

    }
}
 