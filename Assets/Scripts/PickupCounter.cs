using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupCounter : MonoBehaviour
{
    private int startCount = 0;

    [SerializeField] private Text countText;

    // Start is called before the first frame update
    void Start()
    {
        startCount = GameObject.FindGameObjectsWithTag("Pick Up").Length;
    }

    // Update is called once per frame
    void Update()
    {
        int currentCount = 0;
        GameObject[] pickups = GameObject.FindGameObjectsWithTag("Pick Up");
        foreach (GameObject pickup in pickups)
        {
            if (pickup.activeInHierarchy)
            {
                currentCount++;
            }
        }
        countText.text = "Count: " + (startCount - currentCount);
    }
}
