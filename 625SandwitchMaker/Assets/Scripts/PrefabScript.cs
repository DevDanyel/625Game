using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabScript : MonoBehaviour
{

    SpriteRenderer m_SpriteRenderer;
    public Sprite[] goodIngre;
    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.sprite = goodIngre[Random.Range(0, 7)];
    }

    // Update is called once per frame
    void Update()
    {
       if(transform.position.y < -5){
        Destroy(this.gameObject);
       } 
    }
}
