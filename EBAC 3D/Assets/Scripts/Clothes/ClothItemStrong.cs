using System.Collections;
using System.Collections.Generic;
using UnityEngine;




namespace Cloth
{
    public class ClothItemStrong : ClothesItemBase
    {

        public float damageMultiplier = .5f;
        public override void Collect()
        {
            base.Collect();
            Player.Instance.healthBase.ChangeDamageMultiply(damageMultiplier, duration);
        }



    }
}