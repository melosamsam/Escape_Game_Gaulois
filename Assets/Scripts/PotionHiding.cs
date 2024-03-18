using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PotionHiding : MonoBehaviour
{
    private Renderer potionRenderer;
    private StaffPlaced staffPlacedScript;
    private FishPlaced fishPlacedScript;
    private HammerPlaced hammerPlacedScript;
    private RingPlaced ringPlacedScript;
    private VasePlaced vasePlacedScript;
    private SicklePlaced sicklePlacedScript;

    void Start()
    {
        potionRenderer = GetComponent<Renderer>();
        potionRenderer.enabled = false;

        Debug.Log("Potion Invisble");

        staffPlacedScript = FindObjectOfType<StaffPlaced>();
        fishPlacedScript= FindObjectOfType<FishPlaced> ();
        hammerPlacedScript = FindObjectOfType<HammerPlaced>();
        ringPlacedScript = FindObjectOfType<RingPlaced >();
        vasePlacedScript = FindObjectOfType<VasePlaced >();
        sicklePlacedScript = FindObjectOfType< SicklePlaced>();

    }

    void Update()
    {
        if (staffPlacedScript != null)
        {
            if (staffPlacedScript.isOccupied)
            {
                potionRenderer.enabled = true;
            }
            else
            {
                potionRenderer.enabled = false;
            }
        }
    }
}
