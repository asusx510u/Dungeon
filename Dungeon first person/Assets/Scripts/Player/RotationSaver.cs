using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationSaver : MonoBehaviour, IDataPersistence
{
    public void LoadData(GameData data) 
    {
        this.transform.rotation = data.scene.playerCameraRotation;
    }

    public void SaveData(GameData data) 
    {
        data.scene.playerCameraRotation = this.transform.rotation;
    }
}
