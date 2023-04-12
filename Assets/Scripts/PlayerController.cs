using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform PickUpSpawnPlatform;

    private GameObject item;

    public void RemoveItem()
    {
        item = null;
    }

    public void SetItem(GameObject newItem)
    {
        if (item != null)
        {
            item.GetComponent<DestroyItemController>().DestroyMe();
            item = null;
        }

        Vector3 elevatedAmount = new Vector3(0f, 0.1f, 0f);
        Vector3 elevatedPosition = PickUpSpawnPlatform.transform.position + elevatedAmount;

        item = Instantiate(newItem, elevatedPosition, PickUpSpawnPlatform.transform.rotation, PickUpSpawnPlatform);
    }
}
