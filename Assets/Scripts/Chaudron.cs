using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaudron : MonoBehaviour
{
    private List<string> potions = new List<string>();
    public GameObject potionTP;
    public GameObject potionG;
    public GameObject potionP;
    public GameObject potionR;
    private Vector3 posG;
    private Vector3 posP;
    private Vector3 posR;
    void Start()
    {
        posG = potionG.transform.position;
        posR = potionR.transform.position;
        posP = potionP.transform.position;
    }
    private void Update()
    {
        if (potions.Count >= 2 && !potions.Contains("Potion_Stamina"))
        {
            potionTP.gameObject.SetActive(true);
        }
        if(potions.Count >2 && potions.Contains("Potion_Stamina"))
        {
            potions.Clear();
            potionG.transform.position = posG;
            potionG.SetActive(true);
            potionR.transform.position = posR;
            potionR.SetActive(true);
            potionP.transform.position = posP;
            potionP.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Potion"))
        {
            potions.Add(collision.gameObject.name);
            collision.gameObject.SetActive(false);
        }
    }
}
