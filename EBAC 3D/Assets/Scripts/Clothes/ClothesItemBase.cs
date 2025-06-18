using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Cloth
{
    public class ClothesItemBase : MonoBehaviour
    {

        public ClothesType clothType;
        public float duration = 10f;

        public string compareTag = "Player";


        private void OnTriggerEnter(Collider collision)
        {
            if (collision.transform.CompareTag(compareTag))
            {
                Collect();
            }
        }


        public virtual void Collect()
        {
            Debug.Log("ClothCollect");
            var setup = ClothesManager.Instance.GetSetupByType(clothType);

            Player.Instance.ChangeTexture(setup, duration);

            HideObject();
        }

        private void HideObject()
        {
            gameObject.SetActive(false);
        }


    }
}