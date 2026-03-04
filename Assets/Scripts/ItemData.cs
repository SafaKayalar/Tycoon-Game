using UnityEngine;

[CreateAssetMenu(fileName = "Item Data", menuName = "Data/Item")]
public class ItemData : ScriptableObject
{
    public Sprite itemSprite;
    public int price;
    public GameObject item;
}
