using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaudron : MonoBehaviour
{
    private List<string> potions = new List<string>();
    public GameObject potionTP;
    void Start()
    {
        
    }
    private void Update()
    {
        if (potions.Count > 2)
        {
            potionTP.gameObject.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Potion"))
        {
            potions.Add(collision.gameObject.name);
            Destroy(collision.gameObject);
        }
    }
}
