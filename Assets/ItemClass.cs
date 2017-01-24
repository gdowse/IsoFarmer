using UnityEngine;
using System.Collections;

public class ItemClass : MonoBehaviour{

    //Unique ID
    public int ID;
    //Item Name
    public string Name;
    //Type - Environment = 0 Tool = 1 / Seeds = 2 / Food = 3 / Crafting = 4
    public int ItemType;
    //Gold value that is then multiplied by vendor value
    public int BaseCost;
    //Time in hours it takes for seed to grow, if not seed then = 0
    public int GrowTime1;
    public int GrowTime2;

    public Texture2D InventoryTexture;

    //Only used for items that can be planted, seeds
    public Sprite GrowthLevel1;
    public Sprite GrowthLevel2;
    public Sprite GrowthLevel3;
}
