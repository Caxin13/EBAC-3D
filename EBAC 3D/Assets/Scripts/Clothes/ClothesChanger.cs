using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cloth;


namespace Cloth
{
    public class ClothesChanger : MonoBehaviour
    {

        public SkinnedMeshRenderer mesh;

        public Texture2D texture;

        public string ShaderIdName = "_EmissionMap";

        private Texture2D _defaultTexture;

        private void Awake()
        {
          _defaultTexture = (Texture2D) mesh.materials[0].GetTexture(ShaderIdName);

        }


        [NaughtyAttributes.Button]
        private void ChangeTexture()
        {
            mesh.materials[0].SetTexture(ShaderIdName, texture);
        }

        public void ChangeTexture(ClothesSetup setup)
        {
            mesh.materials[0].SetTexture(ShaderIdName, setup.text);
        }

        public void ResetTexture()
        {
            mesh.materials[0].SetTexture(ShaderIdName, _defaultTexture);

        }
    }
}