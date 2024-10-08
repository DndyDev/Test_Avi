using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class LoadSprites : MonoBehaviour {
    public GameObject[] spriteRenderer;
    public List<AssetReference> spriteReferences;


    public void Load() {
        for (int i = 0; i < spriteRenderer.Length; i++) {
            StartCoroutine(LoadSprite(spriteRenderer[i].GetComponent<SpriteRenderer>(), i));
        }
    }

    IEnumerator LoadSprite(SpriteRenderer spriteRenderer, int number) {
        var task = Addressables.LoadAssetAsync<Sprite>(spriteReferences[number]);
        yield return task;
        spriteRenderer.sprite = task.Result;
    }

}
