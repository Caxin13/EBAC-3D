using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Items
{
    public class ItemLayout : MonoBehaviour
    {
        private ItemSetup _currSetup;

        public Image uiIcon;
        public TextMeshProUGUI uiValue;

        public void Load(ItemSetup setup)
        {
            _currSetup = setup;
        }

        private void UpdateUI()
        {

            uiIcon.sprite = _currSetup.icon;
            UpdateUI();
        }

        private void Update()
        {
            uiValue.text = _currSetup.soInt.value.ToString();
        }


    }
}