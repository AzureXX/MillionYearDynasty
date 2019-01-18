using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "TileStats")]
public class TileStats : ScriptableObject
{
    [SerializeField] string type;
    [SerializeField] TileBase tileAsset;

    public string Type { get => type; set => type = value; }
    public TileBase TileAsset { get => tileAsset; set => tileAsset = value; }
}
