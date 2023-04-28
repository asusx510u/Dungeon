using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSaver : MonoBehaviour, IDataPersistence
{
    public void LoadData(GameData data) 
    {
        this.transform.position = data.scene.playerPosition;
        this.transform.rotation = data.scene.playerRotation;
    }

    public void SaveData(GameData data) 
    {
        data.scene.playerPosition = this.transform.position;
        data.scene.playerRotation = this.transform.rotation;
    }
}
