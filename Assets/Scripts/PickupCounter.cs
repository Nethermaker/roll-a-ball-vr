using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupCounter : MonoBehaviour
{
    private int count = 0;

    [SerializeField] private Text countText;

    // Start is called before the first frame update
    void Start()
    {
        count = transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        int currentCount = 0;
        foreach (Transform child in transform)
        {
            if (child.gameObject.activeInHierarchy)
            {
                currentCount++;
            }
        }
        countText.text = "Count: " + (count - currentCount);
    }
}
