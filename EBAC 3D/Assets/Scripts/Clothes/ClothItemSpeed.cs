using System.Collections;
using System.Collections.Generic;
using UnityEngine;




namespace Cloth
{
    public class ClothItemSpeed : ClothesItemBase
    {

        public float targetSpeed = 2f;
        public override void Collect()
        {
            base.Collect();
            Player.Instance.ChangeSpeed(targetSpeed, duration);
        }



    }
}