using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DataIntro : MonoBehaviour
{
    public RawImage teamMemberImage;

    public void SelectImage(BaseEventData eventData)
    {
        RawImage gameObject;

        gameObject = eventData.selectedObject.GetComponent<RawImage>();
        teamMemberImage.texture = gameObject.texture;
    }
}
