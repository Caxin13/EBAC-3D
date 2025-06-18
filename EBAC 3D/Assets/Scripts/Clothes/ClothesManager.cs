using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ebac.Core.Singleton;



namespace Cloth
{

    public enum ClothesType
    {
        SPEED,
        STRONG,
        ALT
    }

    public class ClothesManager : Singleton<ClothesManager>
    {
        public List<ClothesSetup> clothesSetup;

        public ClothesSetup GetSetupByType(ClothesType clothType)
        {
            return clothesSetup.Find(i => i.clothesType == clothType);
        }
    }


    [System.Serializable]
    public class ClothesSetup
    {
        public ClothesType clothesType;
        public Texture2D text;
    }
}