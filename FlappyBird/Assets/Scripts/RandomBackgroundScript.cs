using UnityEngine;
using System.Collections;

public class RandomBackgroundScript : MonoBehaviour
{


    void Start()
    {
        (GetComponent<Renderer>() as SpriteRenderer).sprite = Backgrounds[Random.Range(0, Backgrounds.Length)];
    }

    // aktualizowanie tła   jeden  raz  na  klatkę 
    void Update()
    {

    }

    public Sprite[] Backgrounds;
}
