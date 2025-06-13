using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Items;

public class ChestItemCoin : ChestItemBase
{
    public int coinNumber = 5;
    public GameObject coinObject;

    private List<GameObject> _itens = new List<GameObject>();

    public Vector2 RandomRange = new Vector2(-2f, 2f);

    public float tweenEndTime = .5f;

    public override void ShowItem()
    {
        base.ShowItem();
        CreateItems();
    }

    private void CreateItems()
    {
        for(int i = 0; i < coinNumber; i++)
        {
            var item = Instantiate(coinObject);
            item.transform.position = transform.position + Vector3.forward * Random.Range(RandomRange.x, RandomRange.y) + Vector3.right * Random.Range(RandomRange.x, RandomRange.y);
            
            item.transform.DOScale(0, .1f).SetEase(Ease.OutBack).From();
            _itens.Add(item);
        }
    }

    public override void Collect()
    {
        base.Collect();
        foreach(var i in _itens)
        {
            i.transform.DOMoveY(2f, tweenEndTime).SetRelative();
            i.transform.DOScale(0, tweenEndTime/2).SetDelay(tweenEndTime /2);
            ItemManager.Instance.AddByType(ItemType.COIN);

        }
    }

}
